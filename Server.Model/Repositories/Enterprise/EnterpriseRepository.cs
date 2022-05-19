using Server.Model.Context;
using EnterpriseEntity = Server.Model.Entities.Enterprise.Enterprise;

namespace Server.Model.Repositories.Enterprise
{
    public interface IEnterpriseRepository : IBaseRepository<EnterpriseEntity> { }

    public class EnterpriseRepository : BaseRepository<EnterpriseEntity>, IEnterpriseRepository
    {
        public EnterpriseRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}