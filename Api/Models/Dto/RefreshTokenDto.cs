using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models.Dto;

public class RefreshTokenDto
{
    [Required]
    public string RefreshToken { get; set; } = null!;
}
