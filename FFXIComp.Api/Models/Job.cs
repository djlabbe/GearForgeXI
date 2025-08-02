using System.ComponentModel.DataAnnotations;
namespace FFXIComp.Api.Models;

public class Job
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Abbreviation { get; set; } = null!;  // e.g., "WAR"

    public string FullName { get; set; } = null!;      // e.g., "Warrior"

    // Navigation
    public ICollection<GearItemJob> GearItemJobs { get; set; } = new List<GearItemJob>();
}