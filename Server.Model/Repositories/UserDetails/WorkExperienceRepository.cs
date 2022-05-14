using Server.Model.Context;
using Server.Model.Entities.UserDetails;

namespace Server.Model.Repositories.UserDetails
{

    public interface IWorkExperienceRepository : IBaseRepository<WorkExperience> { }

    public class WorkExperienceRepository : BaseRepository<WorkExperience>, IWorkExperienceRepository
    {
        public WorkExperienceRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}