namespace GearForgeXI.Models.Dto;

public class GearSetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public int JobId { get; set; }
    public JobDto Job { get; set; } = null!;
    public List<GearSetItemDto> GearSetItems { get; set; } = new();
}
