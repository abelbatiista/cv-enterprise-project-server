using Microsoft.AspNetCore.Mvc;
using Server.Bl.DTOs.UserDetails;
using Server.Controllers;
using Server.Services.Services.UserDetails;
using Server.Model.Entities.UserDetails;

namespace Server.Presentation.Controllers.UserDetails
{
    public class EducationController : BaseController<Education, EducationDTO>
    {
        public EducationController(IEducationService service) : base(service) { }
    }
}