namespace UpWork.Application.DTOs.Auth.Results
{
    public class ResetPasswordResult
    {
        public bool Succeeded { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
