using Server.Core.BaseModels;

namespace Server.Bl.DTOs.UserDetails
{
    public class EducationDTO : AuditableEntityDto
    {
        public string InstitutionName { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string Description { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
    }
}
