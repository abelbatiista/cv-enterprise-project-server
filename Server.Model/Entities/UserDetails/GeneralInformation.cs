using Server.Core.BaseModels;
using FileEntity = Server.Model.Entities.File.File;

namespace Server.Model.Entities.UserDetails
{
    public class GeneralInformation : AuditableEntity
    {
        public string FullName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Profession { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
