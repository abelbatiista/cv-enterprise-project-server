using Server.Core.BaseModels;

namespace Server.Bl.DTOs.UserDetails
{
    public class WorkExperienceDTO : AuditableEntityDto
    {
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string Location { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string Description { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
    }
}
