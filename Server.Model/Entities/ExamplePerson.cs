using Server.Core.BaseModels;

namespace Server.Model.Entities
{
    public class ExamplePerson: BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}