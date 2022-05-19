using Server.Model.Entities.User;
using Server.Core.BaseModels;
using Server.Model.Entities.Enterprise;

namespace Server.Model.Entities.UserDetails
{
    public class UserDetails : AuditableEntity
    {
        public GeneralInformation GeneralInformation { get; set; }
        public Biography Biography { get; set; }
        public IList<WorkPlataform> WorkPlataforms { get; set; }
        public Contact Contact { get; set; }
        public Social Social { get; set; }
        public IList<Skills> Skills { get; set; }
        public IList<Education> Educations { get; set; }
        public IList<WorkExperience> WorkExperiences { get; set; }
        public string ApplicationIdentityUserId { get; set; }
        public ApplicationIdentityUser ApplicationIdentityUser { get; set; }
        //public IList<Vacant> Vacants { get; set; }
    }
}
