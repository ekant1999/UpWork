using Microsoft.AspNetCore.Mvc;
using UpWork.Application.DTOs.Auth;
using UpWork.Core.Interfaces.Services;
using UpWork.API;
using UpWork.Infrastructure.Data;
using UpWork.Infrastructure.Repositories;

namespace UpWork.API.Controllers
{
    public class AuthController : Controller
    {
        public IConfiguration _configuration { get; }
        private readonly IAuthService _authService;
        private readonly IEmailService _emailService;
        private ApplicationDbContext _applicationDbContext { get; }
        private readonly ClientRepository _clientRepository;
        //private readonly FreelancerRepository _freelancerRepository;

        public AuthController(IConfiguration configuration, IAuthService authService, IEmailService emailService,
                                ApplicationDbContext dbContext, ClientRepository clientRepository)
        {
            _configuration = configuration;
            _authService = authService;
            _emailService = emailService;
            _applicationDbContext = dbContext;
            _clientRepository = clientRepository;
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
 