namespace Application.Models.Identity
{
    public class CurrentUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageName { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public bool EmailConfirmed { get; set; }
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
