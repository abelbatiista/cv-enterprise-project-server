using Server.Model.Context;
using Server.Model.Entities.UserDetails;

namespace Server.Model.Repositories.UserDetails
{

    public interface ISkillsRepository : IBaseRepository<Skills> { }

    public class SkillsRepository : BaseRepository<Skills>, ISkillsRepository
    {
        public SkillsRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}