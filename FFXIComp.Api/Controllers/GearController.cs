using FFXIComp.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class GearController : ControllerBase
{
    private readonly GearDbContext _context;

    public GearController(GearDbContext context)
    {
        _context = context;
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAllGear([FromQuery] string? job)
    {
        var query = _context.GearItems
            .Include(g => g.GearStats)
            .Include(g => g.GearItemJobs)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(job))
        {
            query = query.Where(g =>
                g.GearItemJobs.Any(j => j.JobName.ToLower() == job.ToLower()) ||
                g.GearItemJobs.Count == 0); // Include items with no job restrictions
        }

        query = query.OrderBy(g => g.Name);
        var result = await query.ToListAsync();
        return Ok(result);
    }

    // GET: api/gear/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetGearItem(int id)
    {
        var item = await _context.GearItems
            .Include(g => g.GearStats)
            .Include(g => g.GearItemJobs)
            .FirstOrDefaultAsync(g => g.Id == id);

        return item is null ? NotFound() : Ok(item);
    }
}
