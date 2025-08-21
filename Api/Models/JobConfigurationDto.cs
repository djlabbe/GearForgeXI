using GearForgeXI.Models.Dto;

namespace GearForgeXI.Models;

/// <summary>
/// DTO for job configuration responses
/// </summary>
public class JobConfigurationDto
{
    public int Id { get; set; }
    public int JobId { get; set; }
    public JobDto Job { get; set; } = null!;
    public List<JobBaseStatDto> JobBaseStats { get; set; } = new();
    public List<JobBaseSkillDto> JobBaseSkills { get; set; } = new();
    public List<JobTraitDto> JobTraits { get; set; } = new();
    public List<JobPointBonusDto> JobPointBonuses { get; set; } = new();
    public List<JobGiftDto> JobGifts { get; set; } = new();
    public List<MasterLevelBonusDto> MasterLevelBonuses { get; set; } = new();
}

/// <summary>
/// DTO for job base stat responses
/// </summary>
public class JobBaseStatDto
{
    public int Id { get; set; }
    public int JobConfigurationId { get; set; }
    public int StatId { get; set; }
    public StatDto Stat { get; set; } = null!;
    public string BaseStatRank { get; set; } = string.Empty;
    public int MaxValue { get; set; }
}

/// <summary>
/// DTO for job base skill responses
/// </summary>
public class JobBaseSkillDto
{
    public int Id { get; set; }
    public int JobConfigurationId { get; set; }
    public int StatId { get; set; }
    public StatDto Stat { get; set; } = null!;
    public string SkillRank { get; set; } = string.Empty;
}

/// <summary>
/// DTO for job trait responses
/// </summary>
public class JobTraitDto
{
    public int Id { get; set; }
    public int JobConfigurationId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    public int StatId { get; set; }
    public StatDto Stat { get; set; } = null!;
    public int Value { get; set; }
}

/// <summary>
/// DTO for job point bonus responses
/// </summary>
public class JobPointBonusDto
{
    public int Id { get; set; }
    public int JobConfigurationId { get; set; }
    public int StatId { get; set; }
    public StatDto Stat { get; set; } = null!;
    public int Value { get; set; }
}

/// <summary>
/// DTO for master level bonus responses
/// </summary>
public class MasterLevelBonusDto
{
    public int Id { get; set; }
    public int JobConfigurationId { get; set; }
    public int StatId { get; set; }
    public StatDto Stat { get; set; } = null!;
    public int Value { get; set; }
}

/// <summary>
/// DTO for job gift responses
/// </summary>
public class JobGiftDto
{
    public int Id { get; set; }
    public int JobConfigurationId { get; set; }
    public int StatId { get; set; }
    public StatDto Stat { get; set; } = null!;
    public int Value { get; set; }
}

// Create DTOs
/// <summary>
/// DTO for creating a job configuration
/// </summary>
public class CreateJobConfigurationDto
{
    public int JobId { get; set; }
}

/// <summary>
/// DTO for creating a job base stat
/// </summary>
public class CreateJobBaseStatDto
{
    public int StatId { get; set; }
    public string BaseStatRank { get; set; } = string.Empty;
    public int MaxValue { get; set; }
}

public class UpdateJobBaseStatDto
{
    public int StatId { get; set; }
    public string BaseStatRank { get; set; } = string.Empty;
    public int MaxValue { get; set; }
}

/// <summary>
/// DTO for creating a job base skill
/// </summary>
public class CreateJobBaseSkillDto
{
    public int StatId { get; set; }
    public string SkillRank { get; set; } = string.Empty;
}

/// <summary>
/// DTO for creating a job trait
/// </summary>
public class CreateJobTraitDto
{
    public string Name { get; set; } = string.Empty;
    public int? Level { get; set; }
    public int StatId { get; set; }
    public int Value { get; set; }
}

/// <summary>
/// DTO for updating a job trait
/// </summary>
public class UpdateJobTraitDto
{
    public string Name { get; set; } = string.Empty;
    public int? Level { get; set; }
    public int StatId { get; set; }
    public int Value { get; set; }
}

/// <summary>
/// DTO for creating a job point bonus
/// </summary>
public class CreateJobPointBonusDto
{
    public int StatId { get; set; }
    public int Value { get; set; }
}

/// <summary>
/// DTO for creating a job gift
/// </summary>
public class CreateJobGiftDto
{
    public int StatId { get; set; }
    public int Value { get; set; }
}

/// <summary>
/// DTO for creating a master level bonus
/// </summary>
public class CreateMasterLevelBonusDto
{
    public int StatId { get; set; }
    public int Value { get; set; }
}
