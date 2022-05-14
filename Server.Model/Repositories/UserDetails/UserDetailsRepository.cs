using Microsoft.EntityFrameworkCore;
using Server.Model.Context;
using UserDetailsEntity = Server.Model.Entities.UserDetails.UserDetails;

namespace Server.Model.Repositories.UserDetails
{

    public interface IUserDetailsRepository : IBaseRepository<UserDetailsEntity> 
    {
        Task<UserDetailsEntity> GetByApplicationIdentityUserId(string applicationIdentityUserId);
    }

    public class UserDetailsRepository : BaseRepository<UserDetailsEntity>, IUserDetailsRepository
    {
        public UserDetailsRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<UserDetailsEntity> GetByApplicationIdentityUserId(string applicationIdentityUserId)
        {
            var entity = await _set.Where(x => x.ApplicationIdentityUserId == applicationIdentityUserId).FirstOrDefaultAsync();
            return entity;
        }
    }
}