using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace FFXIComp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WebPageController(HttpClient httpClient, ILogger<WebPageController> logger, GearDbContext context) : ControllerBase
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly ILogger<WebPageController> _logger = logger;
    private readonly GearDbContext _context = context;

    [HttpPost("fetch")]
    [Authorize(Roles = "Admin")]
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
        var (baseStats, baseWarnings) = ExtractStats(description);

        // Log what we extracted for debugging
        _logger.LogInformation("Extracted data - Name: '{Name}', Description: '{Description}', Type: '{Type}', Jobs: '{Jobs}', Base Stats: {BaseStatCount}",
            name, description, equipmentType, jobs, baseStats.Count);

        var result = new
        {
            name,
            description,
            equipmentSlot = equipmentType, // Renamed to be more clear
            jobs = ParseJobList(jobs), // Return as array instead of string
            stats = baseStats,
            warnings = baseWarnings
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
            // Uppercase the first letter of each word
            var titleCaseName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
            _logger.LogInformation("Found name from item icon pattern: {Name}", titleCaseName);
            return titleCaseName;
        }

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
        // Look for the specific Jobs table row structure
        // Pattern: <td class="item-info-header"...><b>Jobs:</b></td><td...>job content</td>
        var jobsRowPattern = @"<td[^>]*class=""[^""]*item-info-header[^""]*""[^>]*><b>Jobs:</b>\s*</td>\s*<td[^>]*>([^<]*(?:<[^>]*>[^<]*)*?)</td>";
        var jobsRowMatch = Regex.Match(htmlContent, jobsRowPattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);

        if (jobsRowMatch.Success)
        {
            var jobsContent = jobsRowMatch.Groups[1].Value;
            _logger.LogInformation("Found jobs content: {JobsContent}", jobsContent);

            // Extract job names from anchor tags within the jobs content
            // Be more specific - only match links that go to actual job pages
            var jobLinkPattern = @"<a\s+href=""/ffxi/(Warrior|Monk|White_Mage|Black_Mage|Red_Mage|Thief|Paladin|Dark_Knight|Beastmaster|Bard|Ranger|Samurai|Ninja|Dragoon|Summoner|Blue_Mage|Corsair|Puppetmaster|Dancer|Scholar|Geomancer|Rune_Fencer)""[^>]*title=""([^""]+)""[^>]*>([^<]+)</a>";
            var jobMatches = Regex.Matches(jobsContent, jobLinkPattern, RegexOptions.IgnoreCase);

            var jobs = new List<string>();
            foreach (Match jobMatch in jobMatches)
            {
                var jobName = jobMatch.Groups[3].Value.Trim(); // Use the link text
                jobs.Add(jobName);
                _logger.LogInformation("Found job: {JobName}", jobName);
            }

            // If no specific job links found, try a more general approach but within the jobs content only
            if (jobs.Count == 0)
            {
                // Look for any links that match known job names in the title or text
                var generalJobPattern = @"<a[^>]*title=""([^""]*(?:Warrior|Monk|White Mage|Black Mage|Red Mage|Thief|Paladin|Dark Knight|Beastmaster|Bard|Ranger|Samurai|Ninja|Dragoon|Summoner|Blue Mage|Corsair|Puppetmaster|Dancer|Scholar|Geomancer|Rune Fencer)[^""]*)""[^>]*>([^<]+)</a>";
                var generalMatches = Regex.Matches(jobsContent, generalJobPattern, RegexOptions.IgnoreCase);

                foreach (Match jobMatch in generalMatches)
                {
                    var titleText = jobMatch.Groups[1].Value.Trim();
                    var linkText = jobMatch.Groups[2].Value.Trim();

                    // Prefer the title text if it contains a job name, otherwise use link text
                    var jobName = titleText.Length > linkText.Length ? titleText : linkText;
                    jobs.Add(jobName);
                    _logger.LogInformation("Found job (general): {JobName}", jobName);
                }
            }

            return string.Join(" / ", jobs);
        }

        _logger.LogInformation("No Jobs table row found");
        return "";
    }

    private List<string> ParseJobList(string jobsString)
    {
        if (string.IsNullOrEmpty(jobsString))
            return new List<string>();

        // Map full job names to abbreviations
        var jobMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"Warrior", "WAR"},
            {"Monk", "MNK"},
            {"White Mage", "WHM"},
            {"Black Mage", "BLM"},
            {"Red Mage", "RDM"},
            {"Thief", "THF"},
            {"Paladin", "PLD"},
            {"Dark Knight", "DRK"},
            {"Beastmaster", "BST"},
            {"Bard", "BRD"},
            {"Ranger", "RNG"},
            {"Samurai", "SAM"},
            {"Ninja", "NIN"},
            {"Dragoon", "DRG"},
            {"Summoner", "SMN"},
            {"Blue Mage", "BLU"},
            {"Corsair", "COR"},
            {"Puppetmaster", "PUP"},
            {"Dancer", "DNC"},
            {"Scholar", "SCH"},
            {"Geomancer", "GEO"},
            {"Rune Fencer", "RUN"}
        };

        var result = new List<string>();
        var jobNames = jobsString.Split(new[] { " / ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var jobName in jobNames)
        {
            var trimmedName = jobName.Trim();
            if (jobMap.TryGetValue(trimmedName, out var abbreviation))
            {
                result.Add(abbreviation);
            }
        }

        return result;
    }

    private (List<object> stats, List<string> warnings) ExtractStats(string description)
    {
        if (string.IsNullOrEmpty(description))
            return (new List<object>(), new List<string>());

        var stats = new List<object>();
        var warnings = new List<string>();

        try
        {
            // Get available stats from database
            var availableStats = _context.Stats.ToList();

            // Create a lookup map for stat names and display names (case-insensitive)
            var statNameMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var stat in availableStats)
            {
                statNameMap[stat.Name.ToLower()] = stat.Name;
                if (!string.IsNullOrEmpty(stat.DisplayName))
                {
                    statNameMap[stat.DisplayName.ToLower()] = stat.Name;
                }
            }

            // Special handling for Unity Ranking stats first
            // Pattern 1: Unity Ranking: "StatName"+min~max (with quotes)
            var unityRankingQuotedMatches = Regex.Matches(description, @"Unity Ranking:\s*""([^""]+)""\+(\d+)~(\d+)", RegexOptions.IgnoreCase);
            foreach (Match unityMatch in unityRankingQuotedMatches)
            {
                var statName = unityMatch.Groups[1].Value; // The stat name in quotes (e.g., "Refresh")
                var maxValue = int.Parse(unityMatch.Groups[3].Value); // The value after the ~ (e.g., 2 from +1~2)

                // Try to find a matching stat (case-insensitive)
                if (statNameMap.TryGetValue(statName.ToLower(), out var matchedStatName))
                {
                    stats.Add(new { statName = matchedStatName, value = maxValue });
                }
                else
                {
                    warnings.Add($"Could not match Unity Ranking stat: \"{statName}\"");
                }
            }

            // Pattern 2: Unity Ranking: StatName+min~max (without quotes)
            var unityRankingUnquotedMatches = Regex.Matches(description, @"Unity Ranking:\s*([^+\s]+)\+(\d+)~(\d+)", RegexOptions.IgnoreCase);
            foreach (Match unityMatch in unityRankingUnquotedMatches)
            {
                var statName = unityMatch.Groups[1].Value.Trim(); // The stat name without quotes (e.g., "Attack")
                var maxValue = int.Parse(unityMatch.Groups[3].Value); // The value after the ~ (e.g., 15 from +10~15)

                // Try to find a matching stat (case-insensitive)
                if (statNameMap.TryGetValue(statName.ToLower(), out var matchedStatName))
                {
                    stats.Add(new { statName = matchedStatName, value = maxValue });
                }
                else
                {
                    warnings.Add($"Could not match Unity Ranking stat: \"{statName}\"");
                }
            }

            // Remove Unity Ranking patterns from description for regular parsing
            var cleanedDescription = description;
            // Remove quoted Unity Ranking patterns first (more specific)
            cleanedDescription = Regex.Replace(cleanedDescription, @"Unity Ranking:\s*""[^""]+""\+\d+~\d+", "", RegexOptions.IgnoreCase);
            // Then remove unquoted Unity Ranking patterns (but be more specific to avoid conflicts)
            cleanedDescription = Regex.Replace(cleanedDescription, @"Unity Ranking:\s*[A-Za-z][A-Za-z\s]*\+\d+~\d+", "", RegexOptions.IgnoreCase);
            // Also remove any trailing/leading whitespace that might be left
            cleanedDescription = cleanedDescription.Trim();

            _logger.LogInformation("Original description: {Original}", description);
            _logger.LogInformation("Cleaned description: {Cleaned}", cleanedDescription);

            // Find numeric values first, then extract preceding text
            var valueMatches = Regex.Matches(cleanedDescription, @"[+-]?\d+%?");

            for (int i = 0; i < valueMatches.Count; i++)
            {
                var valueMatch = valueMatches[i];
                var valueText = valueMatch.Value;

                // Parse the numeric value, ignoring % for now
                var cleanValue = valueText.Replace("%", "");
                if (!int.TryParse(cleanValue, out var value))
                    continue;

                var valueStart = valueMatch.Index;

                // Determine the start position for the stat name
                var statStart = i > 0 ? valueMatches[i - 1].Index + valueMatches[i - 1].Length : 0;

                // Extract the text between the stat start and the current value
                var statText = cleanedDescription.Substring(statStart, valueStart - statStart).Trim();

                // Clean up the stat name by removing common separators and extra whitespace
                var statName = statText
                    .Replace("\"", "") // Remove quotes
                    .Replace("'", "") // Remove apostrophes
                    .Trim(':', '+', '-', ' ', ',')
                    .Trim();

                // Handle special cases for stat name cleanup
                if (statName.Contains("\"") || statName.Contains("'"))
                {
                    // Extract text between quotes if present
                    var quotedMatch = Regex.Match(statName, @"[""']([^""']+)[""']");
                    if (quotedMatch.Success)
                    {
                        statName = quotedMatch.Groups[1].Value.Trim();
                    }
                }

                if (!string.IsNullOrEmpty(statName))
                {
                    // Try to find a matching stat from database (case-insensitive)
                    if (statNameMap.TryGetValue(statName.ToLower(), out var matchedStatName))
                    {
                        stats.Add(new { statName = matchedStatName, value = value });
                    }
                    else
                    {
                        warnings.Add($"Could not match stat: \"{statName}\"");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error parsing stats from description: {Description}", description);
            warnings.Add("Error occurred while parsing stats");
        }

        if (warnings.Any())
        {
            _logger.LogWarning("Stat parsing warnings: {Warnings}", string.Join(", ", warnings));
        }

        return (stats, warnings);
    }
}

public class FetchWebPageRequest
{
    public string Url { get; set; } = "";
}
