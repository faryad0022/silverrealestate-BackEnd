namespace Application.Models.Identity
{
    public class AuthResponse
    {
        public string Id { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Token { get; set; } = "";
        public AuthResponseResult AuthResponseResult { get; set; }
    }
    public enum AuthResponseResult
    {
        EmailNotFound,
        InvalidInputs,
        UserNotFound,
        NotActive,
        NotLoggedIn,
        Success
    }
}
