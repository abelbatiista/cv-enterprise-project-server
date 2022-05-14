using Server.Model.Context;
using Server.Model.Entities.UserDetails;

namespace Server.Model.Repositories.UserDetails
{

    public interface IGeneralInformationRepository : IBaseRepository<GeneralInformation> { }

    public class GeneralInformationRepository : BaseRepository<GeneralInformation>, IGeneralInformationRepository
    {
        public GeneralInformationRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}