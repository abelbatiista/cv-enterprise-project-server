using Server.Core.BaseModels;

namespace Server.Model.Entities.UserDetails
{
    public class Contact : AuditableEntity
    {
        public string Country { get; set; }
        public string Adress { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
