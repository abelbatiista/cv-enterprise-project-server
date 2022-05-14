using Microsoft.EntityFrameworkCore;
using Server.Model.Context;
using FileEntity = Server.Model.Entities.File.File;

namespace Server.Model.Repositories.File
{

    public interface IFileRepository : IBaseRepository<FileEntity> 
    {
        Task<FileEntity> GetByUserId(int userId);
    }

    public class FileRepository : BaseRepository<FileEntity>, IFileRepository
    {
        public FileRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<FileEntity> GetByUserId(int userDetailsId)
        {
            var entity = await _set.Where(x => x.UserDetailsId == userDetailsId).FirstOrDefaultAsync();
            return entity;
        }
    }
}
