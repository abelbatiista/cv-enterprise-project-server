using Server.Bl.DTOs.UserDetails;
using Server.Core.BaseModels;

namespace Server.Bl.DTOs.File
{
    public class FileDTO : AuditableEntityDto
    {
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string OriginalName { get; set; }
        public string Path { get; set; }
        public string ContentType { get; set; }
        public long ContentLength { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
    }
}
