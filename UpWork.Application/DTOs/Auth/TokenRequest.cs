using System.ComponentModel.DataAnnotations;

namespace UpWork.Application.DTOs.Auth
{
    public class TokenRequest
    {
        [Required]
        public string AccessToken { get; set; }

        [Required]
        public string RefreshToken { get; set; }
    }
}
