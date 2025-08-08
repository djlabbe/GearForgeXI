using GearForgeXI.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController(GearDbContext context) : ControllerBase
{
    private readonly GearDbContext _context = context;

    [HttpGet]
    public async Task<IActionResult> GetJobs()
    {
        var query = _context.Jobs
           .Select(j => new JobDto
           {
               Id = j.Id,
               Abbreviation = j.Abbreviation,
               FullName = j.FullName,
               CanDualWield = j.CanDualWield
           });

        var jobs = await query.OrderBy(j => j.Id).ToListAsync();
        return Ok(jobs);
    }
}
