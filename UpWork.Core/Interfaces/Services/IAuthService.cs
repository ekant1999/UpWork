using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Identity.Data;
using System.Threading.Tasks;
using UpWork.Application.DTOs.Auth;
using UpWork.Application.DTOs.Auth.Results;
using LoginRequest = UpWork.Application.DTOs.Auth.LoginRequest;
using RegisterRequest = UpWork.Application.DTOs.Auth.RegisterRequest;

namespace UpWork.Core.Interfaces.Services
{
    public interface IAuthService
    {
        public Task<RegisterResult> ResgisterUserAsync(RegisterRequest registerRequest);

        public Task<ForgetPasswordResult> ForgetPasswordResult(ForgetPasswordRequest forgetPasswordRequest);

        public Task<ResetPasswordResult> ResetPasswordResult(ResetNewPasswordRequest resetPasswordRequest);

        public Task<bool> VerifyResetCodeAsync(VerifyResetCodeRequest emailVerificationResult);

        public Task<LoginResponse> LoginUser(LoginRequest loginRequest);

        public Task<TokenResponse> RefreshTokenAsync(TokenRequest refreshToken);

        Task LogoutAsync(string userId);
    }

}
