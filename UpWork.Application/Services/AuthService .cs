using UpWork.Application.DTOs.Auth;
using UpWork.Application.DTOs.Auth.Results;
using UpWork.Core.Interfaces.Services;

namespace UpWork.Application.Services
{
    public class AuthService : IAuthService
    {
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
            throw new NotImplementedException();
        }

        public Task<bool> VerifyResetCodeAsync(VerifyResetCodeRequest emailVerificationResult)
        {
            throw new NotImplementedException();
        }
    }
}
