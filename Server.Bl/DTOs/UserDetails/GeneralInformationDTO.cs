using Server.Bl.DTOs.File;
using Server.Core.BaseModels;

namespace Server.Bl.DTOs.UserDetails
{
    public class GeneralInformationDTO : AuditableEntityDto
    {
        public string FullName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Profession { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
    }
}
