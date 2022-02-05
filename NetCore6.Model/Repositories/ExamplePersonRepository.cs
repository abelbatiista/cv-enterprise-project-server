using NetCore6.Model.Context;
using NetCore6.Model.Entities;

namespace NetCore6.Model.Repositories
{
    public interface IExamplePersonRepository: IBaseRepository<ExamplePerson> {}

    public class ExamplePersonRepository: BaseRepository<ExamplePerson>, IExamplePersonRepository
    {
        public ExamplePersonRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}