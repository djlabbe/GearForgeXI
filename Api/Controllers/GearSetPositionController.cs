using FFXIComp.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FFXIComp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GearSetPositionsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetPositions()
    {
        var positions = Enum.GetValues<GearSetPosition>()
            .Select(p => p.ToString())
            .ToList();

        return Ok(positions);
    }
}