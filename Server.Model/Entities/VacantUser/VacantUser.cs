using Server.Core.BaseModels;
using Server.Model.Entities.Enterprise;
using UserDetailsEntity = Server.Model.Entities.UserDetails.UserDetails;

namespace Server.Model.Entities.VacantUser
{
    public class VacantUser : AuditableEntity
    {
        public int UserDetailsId { get; set; }
        public virtual UserDetailsEntity UserDetails { get; set; }
        public int VacantId { get; set; }
        public virtual Vacant Vacant { get; set; }
    }
}

