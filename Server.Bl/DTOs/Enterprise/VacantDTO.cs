using Server.Core.BaseModels;

namespace Server.Bl.DTOs.Enterprise
{
    public class VacantDTO : AuditableEntityDto
    {
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int EnterpriseId { get; set; }
        public virtual EnterpriseDTO Enterprise { get; set; }
    }
}
