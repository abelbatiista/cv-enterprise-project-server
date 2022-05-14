using Server.Core.BaseModels;

namespace Server.Bl.DTOs.UserDetails
{
    public class ContactDTO : AuditableEntityDto
    {
        public string Country { get; set; }
        public string Adress { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
    }
}
