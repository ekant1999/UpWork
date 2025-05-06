using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using UpWork.Application.DTOs.Auth;
using UpWork.Application.DTOs.Auth.Results;
using UpWork.Core.Constants;
using UpWork.Core.Entities.Identity;
using UpWork.Core.Interfaces.Services;
using UpWork.Infrastructure.Data;
using UpWork.Infrastructure.Repositories;
using RegisterRequest = UpWork.Application.DTOs.Auth.RegisterRequest;
using LoginRequest = UpWork.Application.DTOs.Auth.LoginRequest;


namespace UpWork.Application.Services
{
    public class AuthService : IAuthService
    {
        private ApplicationDbContext applicationDbContext;
        private ITokenService tokenService;
        private IEmailService emailService;
        private readonly IConfiguration configuration;
        private readonly ClientRepository clientUserRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthService(ApplicationDbContext dbContext, ITokenService tokenService, 
                            IEmailService emailService, IConfiguration configuration,
                            ClientRepository clientRepository, UserManager<ApplicationUser> userManager) 
        {
            applicationDbContext = dbContext;
            this.tokenService = tokenService;
            this.emailService = emailService;
            this.configuration = configuration;
            this.clientUserRepository = clientRepository;
            this._userManager = userManager;
        }

        public Task<ForgetPasswordResult> ForgetPasswordResult(ForgetPasswordRequest forgetPasswordRequest)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<TokenResponse> RefreshTokenAsync(TokenRequest refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task<ResetPasswordResult> ResetPasswordResult(ResetNewPasswordRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<RegisterResult> ResgisterUserAsync(RegisterRequest request)
        {
            var result = new RegisterResult();

            var existingUser = await _userManager.FindByEmailAsync(request.Email);
            if (existingUser != null)
            {
                result.Errors.Add("Email is already registered");
                return result;
            }

            // Create the appropriate user type
            ApplicationUser user = new ApplicationUser();
            PopulateApplicationUser(request, ref user);

            if (request.Role == "Client")
            {
                var clientUser = new ClientUser();
            }
            else
            {
                var freelancerUser = new FreelancerUser();
            }

            // Create the user account
            var createResult = await _userManager.CreateAsync(user, request.Password);
            if (!createResult.Succeeded)
            {
                result.Errors = createResult.Errors.Select(e => e.Description).ToList();
                return result;
            }

            // Assign role
            //await EnsureRoleExists(request.UserType);
            await _userManager.AddToRoleAsync(user, request.Role);
            await _userManager.AddToRoleAsync(user, ApplicationRoles.User);

            // Create initial profile
            //await _userRepository.CreateInitialProfileAsync(user.Id, request.UserType);

            // Generate email verification token
            var verificationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            result.Succeeded = true;
            result.UserId = user.Id;
            result.VerificationToken = verificationToken;
            return result;
        }


        private void PopulateApplicationUser(RegisterRequest registerRequest, ref ApplicationUser user)
        {
            user.UserName = registerRequest.Email;
            user.Email = registerRequest.Email;
            user.FirstName = registerRequest.FirstName;
            user.LastName = registerRequest.LastName;
            user.PhoneNumber = registerRequest.PhoneNumber;
        }

        public Task<bool> VerifyResetCodeAsync(VerifyResetCodeRequest emailVerificationResult)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> LoginUser(DTOs.Auth.LoginRequest loginRequest)
        {
            throw new NotImplementedException();
        }
    }
}
