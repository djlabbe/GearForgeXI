namespace GearForgeXI.Models.Dto;


public class CreateGearSetDto
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public int JobId { get; set; }
    public List<CreateGearSetItemDto> GearSetSlots { get; set; } = new();
}

public class CreateGearSetItemDto
{
    public int GearItemId { get; set; }
    public string Position { get; set; } = null!;
}

public class AddGearSetSlotDto
{
    public int GearItemId { get; set; }
    public string Position { get; set; } = null!;
}

