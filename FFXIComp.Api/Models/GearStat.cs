using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FFXIComp.Api.Models
{
    public class GearStat
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        // Stat name, e.g. "Str", "DEX", "Accuracy"
        [Required]
        public string Name { get; set; } = null!;

        // Stat value for this item
        public int Value { get; set; }

        [JsonIgnore]
        // Foreign key to GearItem
        public int GearItemId { get; set; }
        [JsonIgnore]
        public GearItem GearItem { get; set; } = null!;
    }
}