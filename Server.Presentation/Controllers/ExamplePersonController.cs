using NetCore6.Bl.DTOs;
using NetCore6.Model.Entities;
using NetCore6.Services.Services;

namespace NetCore6.Controllers
{
    public class ExamplePersonController: BaseController<ExamplePerson, ExamplePersonDTO>
    {
        public ExamplePersonController(IExamplePersonService service) : base(service) {}
    }
}