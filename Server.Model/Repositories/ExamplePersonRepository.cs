using Server.Model.Context;
using Server.Model.Entities;

namespace Server.Model.Repositories
{
    public interface IExamplePersonRepository: IBaseRepository<ExamplePerson> {}

    public class ExamplePersonRepository: BaseRepository<ExamplePerson>, IExamplePersonRepository
    {
        public ExamplePersonRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}