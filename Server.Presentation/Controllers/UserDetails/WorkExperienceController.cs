using Microsoft.AspNetCore.Mvc;
using Server.Bl.DTOs.UserDetails;
using Server.Controllers;
using Server.Services.Services.UserDetails;
using Server.Model.Entities.UserDetails;

namespace Server.Presentation.Controllers.UserDetails
{
    public class WorkExperienceController : BaseController<WorkExperience, WorkExperienceDTO>
    {
        public WorkExperienceController(IWorkExperienceService service) : base(service) { }
    }
}