namespace UpWork.Application.DTOs.Auth
{
    public class LoginResponse
    {
        public bool Succeeded { get; set; }
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
        public DateTime AccessTokenExpiration { get; set; }
        public required string UserId { get; set; }
        public required string Email { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public List<string> Roles { get; set; }
        public bool EmailConfirmed { get; set; }

        public required string UserType { get; set; }  // "Client" or "Freelancer"
        public bool IsProfileComplete { get; set; }
    }
}
