using Server.Core.BaseModels;
using Server.Model.Entities.User;

namespace Server.Bl.DTOs.UserDetails
{
    public class UserDetailsDTO : AuditableEntityDto
    {
        public GeneralInformationDTO GeneralInformation { get; set; }
        public BiographyDTO Biography { get; set; }
        public IList<WorkPlataformDTO> WorkPlataforms { get; set; }
        public ContactDTO Contact { get; set; }
        public SocialDTO Social { get; set; }
        public IList<SkillsDTO> Skills { get; set; }
        public IList<EducationDTO> Educations { get; set; }
        public IList<WorkExperienceDTO> WorkExperiences { get; set; }
        public string ApplicationIdentityUserId { get; set; }
        public ApplicationIdentityUser ApplicationIdentityUser { get; set; }
    }
}
