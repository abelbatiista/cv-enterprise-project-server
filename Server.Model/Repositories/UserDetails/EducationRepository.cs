using Server.Model.Context;
using Server.Model.Entities.UserDetails;

namespace Server.Model.Repositories.UserDetails
{

    public interface IEducationRepository : IBaseRepository<Education> { }

    public class EducationRepository : BaseRepository<Education>, IEducationRepository
    {
        public EducationRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}