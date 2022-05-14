using Server.Core.BaseModels;

namespace Server.Model.Entities.UserDetails
{
    public class Social : AuditableEntity
    {
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
        public string GitHub { get; set; }
        public string Facebook { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
