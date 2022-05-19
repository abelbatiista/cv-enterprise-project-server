using Server.Bl.DTOs.Enterprise;
using Server.Controllers;
using Server.Model.Entities.Enterprise;
using Server.Services.Services.Enterprise;

namespace Server.Presentation.Controllers.Enterprise
{
    public class VacantController : BaseController<Vacant, VacantDTO>
    {
        public VacantController(IVacantService service) : base(service) { }
    }
}
