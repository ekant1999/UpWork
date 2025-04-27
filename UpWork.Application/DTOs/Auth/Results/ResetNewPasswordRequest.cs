namespace UpWork.Application.DTOs.Auth.Results
{
    public class ResetNewPasswordRequest
    {
        public required string Email { get; set; }
        public required string NewPassword { get; set; }
    }
}
