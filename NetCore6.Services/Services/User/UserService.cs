using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NetCore6.Core.Constants;
using Server.Bl.DTOs.User;
using Server.Core.Settings;
using Server.Model.Entities.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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
        private readonly IMapper _mapper;
        private readonly IValidator<UserDTO> _validator;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;

        #endregion

        #region CTOR

        public UserService
        (
            IOptions<JWTSettings> jwtSettings,
            IMapper mapper,
            IValidator<UserDTO> validator,
            UserManager<ApplicationIdentityUser> userManager,
            SignInManager<ApplicationIdentityUser> signInManager
        )
        {
            _jwtSettings = jwtSettings.Value;
            _mapper = mapper;
            _validator = validator;
            _userManager = userManager;
            _signInManager = signInManager;
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
                Password = ""
            };

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
                Email = userDto.Email
            };

            var userRegistry = await _userManager.CreateAsync(user, userDto.Password);

            if (userRegistry.Succeeded is false)
            {
                return new AuthenticateResponseDTO { Error = userRegistry.Errors.FirstOrDefault().Code };
            }

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
