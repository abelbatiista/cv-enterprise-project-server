using Server.Model.Context;
using VacantUserEntity = Server.Model.Entities.VacantUser.VacantUser;

namespace Server.Model.Repositories.VacantUser
{

    public interface IVacantUserRepository : IBaseRepository<VacantUserEntity> { }

    public class VacantUserRepository : BaseRepository<VacantUserEntity>, IVacantUserRepository
    {
        public VacantUserRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
