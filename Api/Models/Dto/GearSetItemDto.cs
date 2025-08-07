namespace FFXIComp.Api.Models.Dto;

public class GearSetItemDto
{
    public int Id { get; set; }
    public string Position { get; set; } = null!;
    public GearItemDto? GearItem { get; set; }
}
