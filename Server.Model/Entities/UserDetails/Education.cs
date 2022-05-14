using Server.Core.BaseModels;

namespace Server.Model.Entities.UserDetails
{
    public class Education : AuditableEntity
    {
        public string InstitutionName { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string Description { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
