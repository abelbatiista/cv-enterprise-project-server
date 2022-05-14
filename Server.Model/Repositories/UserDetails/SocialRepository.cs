using Server.Model.Context;
using Server.Model.Entities.UserDetails;

namespace Server.Model.Repositories.UserDetails
{

    public interface ISocialRepository : IBaseRepository<Social> { }

    public class SocialRepository : BaseRepository<Social>, ISocialRepository
    {
        public SocialRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}