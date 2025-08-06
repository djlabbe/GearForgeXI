using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace FFXIComp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WebPageController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<WebPageController> _logger;

    public WebPageController(HttpClient httpClient, ILogger<WebPageController> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    [HttpPost("fetch")]
    public async Task<IActionResult> FetchWebPage([FromBody] FetchWebPageRequest request)
    {
        try
        {
            // Validate URL is from bg-wiki.com for security
            if (!request.Url.Contains("bg-wiki.com/ffxi/"))
            {
                return BadRequest(new { error = "URL must be from bg-wiki.com/ffxi/" });
            }

            // Fetch the webpage
            var response = await _httpClient.GetAsync(request.Url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            // Save content to a debug file for inspection (temporary)
            var debugPath = Path.Combine(Path.GetTempPath(), "bg-wiki-content.html");
            await System.IO.File.WriteAllTextAsync(debugPath, content);
            _logger.LogInformation("Saved content to debug file: {DebugPath}", debugPath);

            // Parse the content for gear information
            var gearData = ParseGearData(content);

            return Ok(gearData);
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Failed to fetch webpage: {Url}", request.Url);
            return BadRequest(new { error = "Failed to fetch webpage" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing webpage: {Url}", request.Url);
            return StatusCode(500, new { error = "Internal server error" });
        }
    }

    private object ParseGearData(string htmlContent)
    {
        var name = ExtractName(htmlContent);
        var description = ExtractDescription(htmlContent);
        var equipmentType = ExtractEquipmentType(htmlContent);
        var jobs = ExtractJobs(htmlContent);

        // Log what we extracted for debugging
        _logger.LogInformation("Extracted data - Name: '{Name}', Description: '{Description}', Type: '{Type}', Jobs: '{Jobs}'",
            name, description, equipmentType, jobs);

        var result = new
        {
            Name = name,
            Description = description,
            EquipmentType = equipmentType,
            Jobs = jobs,
            Warnings = new List<string>()
        };

        return result;
    }

    private string ExtractName(string htmlContent)
    {
        // Look for the item name pattern in the table cell with the item icon
        // Pattern: <a><img ...></a> ItemName <div style="float: right;">
        var nameMatch = Regex.Match(htmlContent, @"</a>\s*([^<]+?)\s*<div\s+style=""float:\s*right;""", RegexOptions.IgnoreCase);
        if (nameMatch.Success)
        {
            var name = nameMatch.Groups[1].Value.Trim();
            _logger.LogInformation("Found name from item icon pattern: {Name}", name);
            return name;
        }

        // // Fallback to page title if the icon pattern doesn't work
        // var titleMatch = Regex.Match(htmlContent, @"<title>([^<]+?)\s*(?:\|\s*FFXI Wiki|-\s*FFXI Wiki)?</title>", RegexOptions.IgnoreCase);
        // if (titleMatch.Success)
        // {
        //     var title = titleMatch.Groups[1].Value.Trim();
        //     // Remove " - FFXI Wiki" suffix if present
        //     title = Regex.Replace(title, @"\s*-\s*FFXI Wiki$", "", RegexOptions.IgnoreCase).Trim();
        //     _logger.LogInformation("Found name from title fallback: {Name}", title);
        //     return title;
        // }

        _logger.LogWarning("No name pattern matched");
        return "";
    }

    private string ExtractDescription(string htmlContent)
    {
        // Look for the td with class "item-info-body" which contains the description
        var descMatch = Regex.Match(htmlContent, @"<td[^>]*class=""[^""]*item-info-body[^""]*""[^>]*>([^<]+)</td>", RegexOptions.IgnoreCase);
        if (descMatch.Success)
        {
            var description = descMatch.Groups[1].Value.Trim();
            _logger.LogInformation("Found description with item-info-body class: {Description}", description);
            return description;
        }

        _logger.LogWarning("No item-info-body pattern matched");
        return "";
    }

    private string ExtractEquipmentType(string htmlContent)
    {
        // Look for "<b>Equip. Slot:</b>" followed by the next td sibling
        var slotMatch = Regex.Match(htmlContent, @"<td[^>]*><b>Equip\.\s*Slot:</b></td>\s*<td[^>]*>([^<]+)</td>", RegexOptions.IgnoreCase);
        if (slotMatch.Success)
        {
            var slot = slotMatch.Groups[1].Value.Trim();
            _logger.LogInformation("Found equipment slot: {Slot}", slot);
            return slot;
        }

        // Alternative pattern in case there are additional elements or different formatting
        var slotMatch2 = Regex.Match(htmlContent, @"<td[^>]*>[^<]*<b>[^<]*Equip\.\s*Slot:[^<]*</b>[^<]*</td>\s*<td[^>]*>([^<]+)</td>", RegexOptions.IgnoreCase);
        if (slotMatch2.Success)
        {
            var slot2 = slotMatch2.Groups[1].Value.Trim();
            _logger.LogInformation("Found equipment slot with alternative pattern: {Slot}", slot2);
            return slot2;
        }

        _logger.LogInformation("No Equip. Slot pattern found, leaving equipment type blank");
        return "";
    }

    private string ExtractJobs(string htmlContent)
    {
        // Look for job listings in various formats
        var jobPattern = @"(White Mage|Black Mage|Red Mage|Thief|Paladin|Dark Knight|Beastmaster|Bard|Ranger|Samurai|Ninja|Dragoon|Summoner|Blue Mage|Corsair|Puppetmaster|Dancer|Scholar|Geomancer|Rune Fencer)";
        var jobMatches = Regex.Matches(htmlContent, jobPattern, RegexOptions.IgnoreCase);

        var jobs = jobMatches.Cast<Match>().Select(m => m.Value).Distinct().ToList();
        return string.Join(" / ", jobs);
    }
}

public class FetchWebPageRequest
{
    public string Url { get; set; } = "";
}
