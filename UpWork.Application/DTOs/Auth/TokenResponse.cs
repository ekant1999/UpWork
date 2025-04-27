namespace UpWork.Application.DTOs.Auth
{
    public class TokenResponse
    {
        public bool Succeeded { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime AccessTokenExpiration { get; set; }
        public string Error { get; set; }
    }
}
