using Microsoft.AspNetCore.Mvc;
using Server.Bl.DTOs.UserDetails;
using Server.Controllers;
using Server.Services.Services.UserDetails;
using UserDetailsEntity = Server.Model.Entities.UserDetails.UserDetails;

namespace Server.Presentation.Controllers.UserDetails
{
    public class UserDetailsController : BaseController<UserDetailsEntity, UserDetailsDTO>
    {
        private readonly IUserDetailsService _userDetailsService;
        public UserDetailsController
        (
            IUserDetailsService service
        ) 
        : base(service) 
        {
            _userDetailsService = service;
        }

        [HttpGet("[action]/{applicationIdentityUserId}")]
        public virtual async Task<IActionResult> GetByApplicationIdentityUserId([FromRoute] string applicationIdentityUserId)
        {
            var result = await _userDetailsService.GetByApplicationIdentityUserId(applicationIdentityUserId);

            if (result is null)
                return NotFound($"The record with applicationIdentityUserId {applicationIdentityUserId} was not found");

            return Ok(result);
        }
    }
}