namespace GearForgeXI.Models.Dto;

public class GearItemDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Category { get; set; }
    public int? Rank { get; set; }
    public string? Path { get; set; }
    public bool Verified { get; set; } = false;
    public bool IsCustom { get; set; } = false;
    public string? CreatedByUserId { get; set; }
    public List<GearStatDto> Stats { get; set; } = [];
    public List<string> Jobs { get; set; } = [];         // e.g., ["WAR", "NIN"]
    public List<string> Slots { get; set; } = [];        // e.g., ["Main", "Sub"]
}

