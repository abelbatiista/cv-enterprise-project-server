using Server.Model.Context;
using Server.Model.Entities.Enterprise;

namespace Server.Model.Repositories.Enterprise
{
    public interface IVacantRepository : IBaseRepository<Vacant> { }

    public class VacantRepository : BaseRepository<Vacant>, IVacantRepository
    {
        public VacantRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}