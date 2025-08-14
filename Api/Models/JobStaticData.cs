namespace GearForgeXI.Models;

public class JobStaticData
{
    public List<JobTrait> Traits { get; set; } = new();
    /// <summary>
    /// Dictionary mapping Stat ID to job point bonus value
    /// </summary>
    public Dictionary<int, int> JobPointBonuses { get; set; } = new();
    /// <summary>
    /// Dictionary mapping Stat ID to master level bonus value
    /// </summary>
    public Dictionary<int, int> MasterLevelBonuses { get; set; } = new();
}
