using Server.Model.Context;
using Server.Model.Entities.UserDetails;

namespace Server.Model.Repositories.UserDetails
{

    public interface IWorkPlataformRepository : IBaseRepository<WorkPlataform> { }

    public class WorkPlataformRepository : BaseRepository<WorkPlataform>, IWorkPlataformRepository
    {
        public WorkPlataformRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}