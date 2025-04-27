namespace UpWork.Application.DTOs.Auth.Results
{

    public class RegisterResult
    {
        public bool Succeeded { get; set; }
        public required string UserId { get; set; }
        public required string VerificationToken { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
