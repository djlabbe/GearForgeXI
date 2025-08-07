namespace FFXIComp.Api.Models.Dto;

public class GearSetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public List<GearSetItemDto> GearSetItems { get; set; } = new();
}
