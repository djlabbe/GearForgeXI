namespace GearForgeXI.Models;

public class CalculateStatsRequest
{
    public int RaceId { get; set; }
    public int MainJobId { get; set; }

    public int MasterLevel { get; set; }
    public int? SubJobId { get; set; }
    public int? GearSetId { get; set; }
}