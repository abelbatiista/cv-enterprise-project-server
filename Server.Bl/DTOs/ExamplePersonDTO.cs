using NetCore6.Core.BaseModels;

namespace NetCore6.Bl.DTOs
{
    public class ExamplePersonDTO: BaseEntityDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}