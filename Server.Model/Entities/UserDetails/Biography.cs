using Server.Core.BaseModels;

namespace Server.Model.Entities.UserDetails
{
    public class Biography : AuditableEntity
    {
        public string Bio { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
