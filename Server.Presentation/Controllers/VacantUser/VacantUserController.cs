using Server.Bl.DTOs.VacantUser;
using Server.Controllers;
using Server.Services.Services.VacantUser;
using VacantUserEntity = Server.Model.Entities.VacantUser.VacantUser;

namespace Server.Presentation.Controllers.VacantUser
{
    public class VacantUserController : BaseController<VacantUserEntity, VacantUserDTO>
    {
        public VacantUserController(IVacantUserService service) : base(service) { }
    }
}
