namespace GearForgeXI.Models;

public class GearItemStat
{
    public int Id { get; set; }

    public int GearItemId { get; set; }
    public GearItem GearItem { get; set; } = null!;

    public int StatId { get; set; }
    public Stat Stat { get; set; } = null!;

    public int? Value { get; set; }
}