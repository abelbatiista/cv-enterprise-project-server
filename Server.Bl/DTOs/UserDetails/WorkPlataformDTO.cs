using Server.Core.BaseModels;

namespace Server.Bl.DTOs.UserDetails
{
    public class WorkPlataformDTO : AuditableEntityDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
    }
}
