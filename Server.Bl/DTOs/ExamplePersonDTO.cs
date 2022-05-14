using Server.Core.BaseModels;

namespace Server.Bl.DTOs
{
    public class ExamplePersonDTO: BaseEntityDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}