namespace UpWork.Application.DTOs.Auth.Results
{
    public class ForgetPasswordResult
    {
        public bool Succeeded { get; set; }
        public required string Email { get; set; }
        public required string ResetToken { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
