using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Server.Core.Constants;
using Server.Bl.DTOs.User;
using Server.Core.Settings;
using Server.Model.Entities.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Server.Services.Services.UserDetails;
using Server.Bl.DTOs.UserDetails;

namespace Server.Services.Services.User
{
    public interface IUserService
    {
        Task<IEnumerable<ApplicationIdentityUser>> Users();
        Task<AuthenticateResponseDTO> SignUp(UserDTO userDto);
        Task<AuthenticateResponseDTO> SignIn(UserDTO userDto);
        Task SignOut();
        Task<AuthenticateResponseDTO> Refresh(string email);
    }
    public class UserService : IUserService
    {

        #region Fields

        private readonly JWTSettings _jwtSettings;
        private readonly IValidator<UserDTO> _validator;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;
        private readonly IUserDetailsService _userDetailsService;

        #endregion

        #region CTOR

        public UserService
        (
            IOptions<JWTSettings> jwtSettings,
            IValidator<UserDTO> validator,
            UserManager<ApplicationIdentityUser> userManager,
            SignInManager<ApplicationIdentityUser> signInManager,
            IUserDetailsService userDetailsService
        )
        {
            _jwtSettings = jwtSettings.Value;
            _validator = validator;
            _userManager = userManager;
            _signInManager = signInManager;
            _userDetailsService = userDetailsService;
        }

        #endregion

        #region Private Methods

        private async Task<AuthenticateResponseDTO> GenerateToken(string email)
        {
            var claims = new List<Claim>()
            {
                new Claim("email", email),
            };

            var user = await _userManager.FindByEmailAsync(email);

            var userDto = new UserDTO
            {
                Id = user.Id,
                Email = user.Email,
                Password = null,
                Name = user.Name,
                Lastname = user.Lastname
            };

            var userDetails = await _userDetailsService.GetByApplicationIdentityUserId(user.Id);

            var claimDB = await _userManager.GetClaimsAsync(user);

            claims.AddRange(claimDB);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var securityToken = new JwtSecurityToken
            (
                issuer: null,
                audience: null,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.ExpiresInMinutes),
                signingCredentials: creds
            );

            return new AuthenticateResponseDTO
            {
                User = userDto,
                ApplicationIdentityUser = user,
                UserDetails = userDetails,
                Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
            };
        }

        #endregion

        #region Methods

        public async Task<IEnumerable<ApplicationIdentityUser>> Users()
        {
            var users = _userManager.Users;
            return users;
        }
        public async Task<AuthenticateResponseDTO> SignUp(UserDTO userDto)
        {

            var userValidation = _validator.Validate(userDto);

            if (userValidation.IsValid is false)
            {
                return new AuthenticateResponseDTO { Error = userValidation.Errors.FirstOrDefault().ErrorCode };
            }
            var user = new ApplicationIdentityUser
            {
                UserName = userDto.Email,
                Email = userDto.Email,
                Name = userDto.Name,
                Lastname = userDto.Lastname
            };

            var userRegistry = await _userManager.CreateAsync(user, userDto.Password);

            if (userRegistry.Succeeded is false)
            {
                return new AuthenticateResponseDTO { Error = userRegistry.Errors.FirstOrDefault().Code };
            }

            var Id = await _userManager.GetUserIdAsync(user);
            await _userDetailsService.AddAsync(new UserDetailsDTO
            {
                ApplicationIdentityUserId = Id
            });

            return await GenerateToken(user.Email);
        }
        public async Task<AuthenticateResponseDTO> SignIn(UserDTO userDto)
        {
            var userLoggedIn = await _signInManager.PasswordSignInAsync
            (
                userDto.Email,
                userDto.Password,
                isPersistent: false,
                lockoutOnFailure: false
            );

            if (userLoggedIn.Succeeded)
            {
                AuthConst.DEFAULT_USER = userDto.Email;
                return await GenerateToken(userDto.Email);
            }

            else return null;
        }
        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<AuthenticateResponseDTO> Refresh(string email)
        {
            return await GenerateToken(email);
        }

        #endregion
    }
}
