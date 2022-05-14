using Server.Core.BaseModels;

namespace Server.Bl.DTOs.UserDetails
{
    public class BiographyDTO : AuditableEntityDto
    {
        public string Bio { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
    }
}
