namespace GearForgeXI.Models.Dto;

public class TokenResponseDto
{
    public string AccessToken { get; set; } = null!;
    public string RefreshToken { get; set; } = null!;
    public DateTime ExpiresAt { get; set; }
    public string Message { get; set; } = null!;
}
