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

    // GET: api/gear/head
    [HttpGet("head")]
    public async Task<IActionResult> GetHeadGear()
    {
        var gear = await _context.GearItems
            .Where(g => g.Slot == "Head")
            .Include(g => g.GearStats)
            .Include(g => g.GearItemJobs)
            .OrderBy(g => g.Name)
            .ToListAsync();

        return Ok(gear);
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
