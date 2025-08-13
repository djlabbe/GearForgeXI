using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models;

public class CharacterProfile
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string UserId { get; set; } = null!;

    [Required]
    [MaxLength(15)] // FFXI character name limit
    public string CharacterName { get; set; } = null!;

    [Required]
    public Server Server { get; set; }

    // Race information
    [Required]
    public Race Race { get; set; }

    // Timestamps
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public ApplicationUser User { get; set; } = null!;
    public ICollection<CharacterJob> CharacterJobs { get; set; } = new List<CharacterJob>();
}

public enum Race
{
    HumeMale = 1,
    HumeFemale = 2,
    ElvaanMale = 3,
    ElvaanFemale = 4,
    TarutaruMale = 5,
    TarutaruFemale = 6,
    MithraFemale = 7,
    GalkanMale = 8,
}

public enum Server
{
    Bahamut = 1,
    Shiva = 2,
    Phoenix = 3,
    Carbuncle = 4,
    Fenrir = 5,
    Sylph = 6,
    Valefor = 7,
    Leviathan = 8,
    Odin = 9,
    Quetzalcoatl = 10,
    Siren = 11,
    Ragnarok = 12,
    Cerberus = 13,
    Bismarck = 14,
    Lakshmi = 15,
    Asura = 16,
}
