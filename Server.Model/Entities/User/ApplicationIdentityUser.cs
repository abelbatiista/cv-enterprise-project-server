using Microsoft.AspNetCore.Identity;

namespace Server.Model.Entities.User
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
    }
}
