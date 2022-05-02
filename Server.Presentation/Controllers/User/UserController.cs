using Microsoft.AspNetCore.Mvc;
using Server.Bl.DTOs.User;
using Server.Model.Entities.User;
using Server.Services.Services.User;
using System.Security.Claims;

namespace Server.Presentation.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("Users")]
        public async Task<IEnumerable<ApplicationIdentityUser>> Users()
        {
            var users = await _userService.Users();
            return users;
        }

        [HttpPost("SignUp")]
        public async Task<ActionResult<AuthenticateResponseDTO>> SignUp([FromBody] UserDTO userDto)
        {
            var userRegistry = await _userService.SignUp(userDto);

            if (userRegistry is null)
                return BadRequest();

            if (userRegistry.Error is not null)
                return Ok(new ErrorResponse(userRegistry.Error));

            return userRegistry;
        }

        [HttpPost("SignIn")]
        public async Task<ActionResult<AuthenticateResponseDTO>> SignIn([FromBody] UserDTO userDto)
        {
            var userLogin = await _userService.SignIn(userDto);

            if (userLogin is null)
                return BadRequest("Email or Password Incorrect");
            return Ok(userLogin);
        }

        [HttpGet("Refresh")]
        public async Task<ActionResult<AuthenticateResponseDTO>> RefreshToken()
        {
            var emailReponse = HttpContext.User.Claims.Where(claim => claim.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").FirstOrDefault();
            var claims = HttpContext.User.Claims.ToList();
            if (emailReponse is null)
            {
                return BadRequest("Token could not be loaded.");
            }
            var emailClaim = emailReponse.Value;
            return await _userService.Refresh(emailClaim);
        }

        [HttpGet("SignOut")]
        public async Task<IActionResult> Logout()
        {
            await _userService.SignOut();
            return Ok();
        }
    }
}
