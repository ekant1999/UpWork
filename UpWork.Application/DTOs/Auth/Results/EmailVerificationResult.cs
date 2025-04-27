namespace UpWork.Application.DTOs.Auth.Results
{
    public class EmailVerificationResult
    {
        public bool Succeeded { get; set; }
        public string? Message { get; set; }
    }
}
