using Server.Core.BaseModels;

namespace Server.Bl.DTOs.UserDetails
{
    public class SkillsDTO : AuditableEntityDto
    {
        public string Title { get; set; }
        public int Percent { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
    }
}
