using NetCore6.Core.BaseModels;

namespace NetCore6.Model.Entities
{
    public class ExamplePerson: BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}