using Server.Bl.DTOs.Enterprise;
using Server.Controllers;
using EnterpriseEntity = Server.Model.Entities.Enterprise.Enterprise;
using Server.Services.Services.Enterprise;

namespace Server.Presentation.Controllers.Enterprise
{
    public class EnterpriseController : BaseController<EnterpriseEntity, EnterpriseDTO>
    {
        public EnterpriseController(IEnterpriseService service) : base(service) { }
    }
}
