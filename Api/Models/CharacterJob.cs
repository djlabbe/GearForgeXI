using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models;

public class CharacterJob
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int CharacterProfileId { get; set; }

    [Required]
    public int JobId { get; set; }

    // Job level (0-99)
    [Range(0, 99)]
    public int JobLevel { get; set; } = 0;

    // Master levels (0-50)
    [Range(0, 50)]
    public int MasterLevel { get; set; } = 0;

    // Timestamps
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public CharacterProfile CharacterProfile { get; set; } = null!;
    public Job Job { get; set; } = null!;
}
