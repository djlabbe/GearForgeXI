using Microsoft.AspNetCore.Identity;

namespace FFXIComp.Api.Models;

public class ApplicationUser : IdentityUser
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public ICollection<GearSet> GearSets { get; set; } = new List<GearSet>();
}
