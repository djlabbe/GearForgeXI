
using FFXIComp.Api.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFXIComp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatsController : ControllerBase
{
    private readonly GearDbContext _context;

    public StatsController(GearDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllStats([FromQuery] string? category)
    {
        var query = _context.Stats.AsQueryable();

        if (!string.IsNullOrWhiteSpace(category))
        {
            var normalized = category.Trim().ToLower();
            query = query.Where(s => s.Category != null && s.Category.ToLower() == normalized);
        }

        var stats = await query
            .OrderBy(s => s.Category)
            .ThenBy(s => s.DisplayName ?? s.Name)
            .Select(s => new StatDto
            {
                Id = s.Id,
                Name = s.Name,
                DisplayName = s.DisplayName,
                Category = s.Category,
                Description = s.Description
            })
            .ToListAsync();

        return Ok(stats);
    }
}
