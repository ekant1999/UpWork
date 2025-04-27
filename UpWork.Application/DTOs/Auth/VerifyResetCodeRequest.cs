namespace UpWork.UpWork.Application.DTOs.Auth
{
    public class VerifyResetCodeRequest
    {
        public required string Email { get; set; }
        public required string ResetCode { get; set; }
    }
}
