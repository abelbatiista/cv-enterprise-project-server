using Server.Core.BaseModels;

namespace Server.Model.Entities.Enterprise
{
    public class Vacant : AuditableEntity
    {
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int EnterpriseId { get; set; }
        public virtual Enterprise Enterprise { get; set; }
    }
}
