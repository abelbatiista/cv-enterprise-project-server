using Server.Model.Entities.User;
using Server.Bl.DTOs.UserDetails;

namespace Server.Bl.DTOs.User
{
    public class AuthenticateResponseDTO
    {
        public UserDTO? User { get; set; }
        public ApplicationIdentityUser? ApplicationIdentityUser { get; set; }
        public UserDetailsDTO? UserDetails { get; set; }
        public string? Token { get; set; }
        public string? Error { get; set; }
    }
}
