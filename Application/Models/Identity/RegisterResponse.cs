namespace Application.Models.Identity
{
    public class RegisterResponse
    {
        public string UserId { get; set; } = "";
        public RegisterResponseResult RegisterResponseResult { get; set; }
    }
    public enum RegisterResponseResult
    {
        Success,
        EmailExist,
        UserExist,
    }
}
