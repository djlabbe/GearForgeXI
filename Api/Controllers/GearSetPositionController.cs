using GearForgeXI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GearSetPositionsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetPositions()
    {
        var positions = Enum.GetValues<SetPosition>()
            .Select(p => p.ToString())
            .ToList();

        return Ok(positions);
    }
}