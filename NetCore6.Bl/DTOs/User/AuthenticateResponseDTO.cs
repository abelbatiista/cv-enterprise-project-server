namespace Server.Bl.DTOs.User
{
    public class AuthenticateResponseDTO
    {
        public UserDTO? User { get; set; }
        public string? Token { get; set; }
        public string? Error { get; set; }
    }
}
