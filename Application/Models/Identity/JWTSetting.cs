namespace Application.Models.Identity
{
    public class JWTSetting
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string DurationInMinutes { get; set; }
    }
}
