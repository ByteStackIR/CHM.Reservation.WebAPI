namespace WebAPI.Configuration
{
    public class JwtSettings
    {
        public string Section { get; set; } = "JwtSettings";

        public string validIssuer { get; set; }
        public string validAudience { get; set; }
        public string Secret { get; set; }
        public string expires { get; set; }
    }
}
