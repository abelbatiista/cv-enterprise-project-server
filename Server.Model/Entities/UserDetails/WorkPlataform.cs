using Server.Core.BaseModels;

namespace Server.Model.Entities.UserDetails
{
    public class WorkPlataform : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
