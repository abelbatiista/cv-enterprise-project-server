using Server.Core.BaseModels;
using UserDetailsEntity = Server.Model.Entities.UserDetails.UserDetails;

namespace Server.Model.Entities.File
{
    public class File : AuditableEntity
    {
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string OriginalName { get; set; }
        public string Path { get; set; }
        public string ContentType { get; set; }
        public long ContentLength { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsEntity UserDetails { get; set; }
    }
}
