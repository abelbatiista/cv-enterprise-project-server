using Microsoft.AspNetCore.Mvc;
using Server.Bl.DTOs.UserDetails;
using Server.Controllers;
using Server.Services.Services.UserDetails;
using Server.Model.Entities.UserDetails;

namespace Server.Presentation.Controllers.UserDetails
{
    public class SkillsController : BaseController<Skills, SkillsDTO>
    {
        public SkillsController(ISkillsService service) : base(service) { }
    }
}