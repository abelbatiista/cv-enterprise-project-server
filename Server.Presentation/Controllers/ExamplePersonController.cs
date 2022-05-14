using Server.Bl.DTOs;
using Server.Model.Entities;
using Server.Services.Services;

namespace Server.Controllers
{
    public class ExamplePersonController: BaseController<ExamplePerson, ExamplePersonDTO>
    {
        public ExamplePersonController(IExamplePersonService service) : base(service) {}
    }
}