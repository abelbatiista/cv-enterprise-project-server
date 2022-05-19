using Server.Core.BaseModels;

namespace Server.Bl.DTOs.Enterprise
{
    public class EnterpriseDTO : AuditableEntityDto
    {
        public string Title { get; set; }
    }
}
