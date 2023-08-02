namespace Application.Models.Identity
{
    public class AuthResponse
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
