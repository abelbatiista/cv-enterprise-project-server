using Server.Core.BaseModels;

namespace Server.Model.Entities.UserDetails
{
    public class Skills : AuditableEntity
    {
        public string Title { get; set; }
        public int Percent { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
