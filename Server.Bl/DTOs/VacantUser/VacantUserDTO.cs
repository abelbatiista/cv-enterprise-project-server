using Server.Bl.DTOs.Enterprise;
using Server.Bl.DTOs.UserDetails;
using Server.Core.BaseModels;

namespace Server.Bl.DTOs.VacantUser
{
    public class VacantUserDTO : AuditableEntityDto
    {
        public int UserDetailsId { get; set; }
        public virtual UserDetailsDTO UserDetails { get; set; }
        public int VacantId { get; set; }
        public virtual VacantDTO Vacant { get; set; }
    }
}
