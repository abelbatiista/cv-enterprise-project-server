using Server.Core.BaseModels;

namespace Server.Bl.DTOs.UserDetails
{
    public class SocialDTO : AuditableEntityDto
    {
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
        public string GitHub { get; set; }
        public string Facebook { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
    }
}
