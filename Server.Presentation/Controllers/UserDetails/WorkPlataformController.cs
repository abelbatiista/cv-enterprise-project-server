using Microsoft.AspNetCore.Mvc;
using Server.Bl.DTOs.UserDetails;
using Server.Controllers;
using Server.Services.Services.UserDetails;
using Server.Model.Entities.UserDetails;

namespace Server.Presentation.Controllers.UserDetails
{
    public class WorkPlataformController : BaseController<WorkPlataform, WorkPlataformDTO>
    {
        public WorkPlataformController(IWorkPlataformService service) : base(service) { }
    }
}