using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FFXIComp.Api.Models
{
    // Many-to-many join table: GearItem <-> Job
    public class GearItemJob
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        public string JobName { get; set; } = null!; // e.g. "WAR", "MNK", "THF"

        // Foreign key to GearItem
        [JsonIgnore]
        public int GearItemId { get; set; }

        [JsonIgnore]
        public GearItem GearItem { get; set; } = null!;
    }
}