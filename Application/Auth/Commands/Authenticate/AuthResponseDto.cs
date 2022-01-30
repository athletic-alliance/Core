namespace AthleticAlliance.Application.Auth.Commands.Authenticate;

public class AuthResponseDto
{
    public string AccessToken { get; set; }

    public string RefreshToken { get; set; }

    public AuthResponseDto(string accessToken, string refreshToken)
    {
        AccessToken = accessToken;
        RefreshToken = refreshToken;
    }
}