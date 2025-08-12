using Microsoft.AspNetCore.Identity;

namespace GearForgeXI.Models;

public class ApplicationUser : IdentityUser
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public ICollection<GearSet> GearSets { get; set; } = new List<GearSet>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    public ICollection<CharacterProfile> CharacterProfiles { get; set; } = new List<CharacterProfile>();
}
