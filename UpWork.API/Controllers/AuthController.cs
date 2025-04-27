using Microsoft.AspNetCore.Mvc;
using UpWork.Application.DTOs.Auth;
using UpWork.Core.Interfaces.Services;
using UpWork.UpWork.API;

namespace UpWork.API.Controllers
{
    public class AuthController : Controller
    {
        public IConfiguration _configuration { get; }
        private readonly IAuthService _authService;
        private readonly IEmailService _emailService;


        //public ApplicationDbContext _applicationDbContext { get; }

        public AuthController(IConfiguration configuration, IAuthService authService, IEmailService emailService)
        {
            _configuration = configuration;
            _authService = authService;
            _emailService = emailService;
        }

        // httpost register
        [HttpPost("api/register")]
        [ServiceFilter(typeof(ValidateModelStateFilter))]
        public async Task<IActionResult> Register([FromBody] RegisterRequest requestData)
        {
            var result = await _authService.ResgisterUserAsync(requestData);

            if(!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok();
        }
    }
}
 