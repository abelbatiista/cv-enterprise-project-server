using Server.Model.Context;
using Server.Model.Entities.UserDetails;

namespace Server.Model.Repositories.UserDetails
{

    public interface IBiographyRepository : IBaseRepository<Biography> { }

    public class BiographyRepository : BaseRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
