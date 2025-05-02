using System.ComponentModel.DataAnnotations;

namespace UpWork.Application.DTOs.Auth
{
    public class RegisterRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }

        [Required, MinLength(6), Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; }
    }

}
