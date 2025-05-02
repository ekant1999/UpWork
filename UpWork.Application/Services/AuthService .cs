using UpWork.Application.DTOs.Auth;
using UpWork.Application.DTOs.Auth.Results;
using UpWork.Core.Entities.Identity;
using UpWork.Core.Interfaces.Services;
using UpWork.Infrastructure.Data;

namespace UpWork.Application.Services
{
    public class AuthService : IAuthService
    {
        private ApplicationDbContext applicationDbContext;
        private ITokenService tokenService;
        private IEmailService emailService;
        private readonly IConfiguration configuration;

        public AuthService(ApplicationDbContext dbContext, ITokenService tokenService, IEmailService emailService, IConfiguration configuration) 
        {
            applicationDbContext = dbContext;
            this.tokenService = tokenService;
            this.emailService = emailService;
            this.configuration = configuration;
        }

        public Task<ForgetPasswordResult> ForgetPasswordResult(ForgetPasswordRequest forgetPasswordRequest)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> LoginUser(LoginRequest loginRequest)
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

        public Task<ResetPasswordResult> ResetPasswordResult(ResetNewPasswordRequest resetPasswordRequest)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterResult> ResgisterUserAsync(RegisterRequest registerRequest)
        {
            ApplicationUser user = new ApplicationUser();
            PopulateApplicationUser(registerRequest, ref user);
            var token = tokenService.GenerateToken(user.Id);
            var result = applicationDbContext.ApplicationUsers.AddAsync(user);
            if (result.IsCompletedSuccessfully)
                return Task.FromResult(new RegisterResult
                {
                    Succeeded = true,
                    UserId = user.Id,
                    VerificationToken = token
                });
            else
                return Task.FromResult(new RegisterResult
                {
                    Succeeded = false,
                    Errors = new List<string> { "User registration failed." }
                });
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
    }
}
