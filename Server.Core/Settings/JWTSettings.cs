namespace Server.Core.Settings
{
    public class JWTSettings
    {
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public int ExpiresInMinutes { get; set; }
    }
}
