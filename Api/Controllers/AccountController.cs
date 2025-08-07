using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FFXIComp.Api.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FFXIComp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController(
    UserManager<IdentityUser> userManager,
    SignInManager<IdentityUser> signInManager
) : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager = userManager;
    private readonly SignInManager<IdentityUser> _signInManager = signInManager;

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRegisterDto dto)
    {
        var user = new IdentityUser
        {
            UserName = dto.Email,
            Email = dto.Email
        };

        var result = await _userManager.CreateAsync(user, dto.Password);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        // Assign the User role to the newly created user
        var roleResult = await _userManager.AddToRoleAsync(user, "User");
        if (!roleResult.Succeeded)
        {
            // If role assignment fails, we could either delete the user or log the error
            // For now, we'll continue but could log this issue
            return BadRequest(new { Message = "User created but role assignment failed", roleResult.Errors });
        }

        return Ok("User registered successfully");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user == null)
            return Unauthorized("Invalid login");

        var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
        if (!result.Succeeded)
            return Unauthorized("Invalid login");

        var token = await GenerateJwtToken(user);
        return Ok(new { token });
    }

    private async Task<string> GenerateJwtToken(IdentityUser user)
    {
        var jwtSettings = new JwtSecurityTokenHandler();

        var jwtKey = Environment.GetEnvironmentVariable("FFXICOMP_JWT_KEY")
            ?? throw new Exception("FFXICOMP_JWT_KEY not set");

        var jwtIssuer = Environment.GetEnvironmentVariable("FFXICOMP_JWT_ISSUER")
            ?? throw new Exception("FFXICOMP_JWT_ISSUER not set");

        var key = Encoding.UTF8.GetBytes(jwtKey);

        // Get user roles
        var userRoles = await _userManager.GetRolesAsync(user);

        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id),
            new Claim(JwtRegisteredClaimNames.Email, user.Email!),
            new Claim(ClaimTypes.NameIdentifier, user.Id)
        };

        // Add role claims
        foreach (var role in userRoles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        var token = new JwtSecurityToken(
            issuer: jwtIssuer,
            audience: null,
            claims: claims,
            expires: DateTime.UtcNow.AddHours(6),
            signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256
            )
        );

        return jwtSettings.WriteToken(token);
    }
}
