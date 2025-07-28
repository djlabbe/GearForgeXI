using System.ComponentModel.DataAnnotations;

namespace FFXIComp.Api.Models
{
    public class GearItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        // Slot like Head, Body, Hands, etc.
        [Required]
        public string Slot { get; set; } = null!;

        // Navigation properties
        public ICollection<GearItemJob> GearItemJobs { get; set; } = new List<GearItemJob>();
        public ICollection<GearStat> GearStats { get; set; } = new List<GearStat>();
    }
}
