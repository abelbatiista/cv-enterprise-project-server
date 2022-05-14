using Microsoft.AspNetCore.Mvc;
using Server.Bl.DTOs.UserDetails;
using Server.Controllers;
using Server.Services.Services.UserDetails;
using Server.Model.Entities.UserDetails;

namespace Server.Presentation.Controllers.UserDetails
{
    public class GeneralInformationController : BaseController<GeneralInformation, GeneralInformationDTO>
    {
        public GeneralInformationController(IGeneralInformationService service) : base(service) { }
    }
}