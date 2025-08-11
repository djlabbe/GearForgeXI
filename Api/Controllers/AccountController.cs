using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using GearForgeXI.Models;
using GearForgeXI.Models.Dto;
using GearForgeXI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GearForgeXI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController(
    UserManager<ApplicationUser> userManager,
    SignInManager<ApplicationUser> signInManager,
    RefreshTokenService refreshTokenService
) : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;
    private readonly RefreshTokenService _refreshTokenService = refreshTokenService;

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRegisterDto dto)
    {
        var user = new ApplicationUser
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

        // Generate JWT token for immediate login
        var tokenResponse = await GenerateTokenResponseAsync(user);
        tokenResponse.Message = "User registered successfully";
        return Ok(tokenResponse);
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
        var refreshToken = await _refreshTokenService.GenerateRefreshTokenAsync(user.Id);

        return Ok(new TokenResponseDto
        {
            AccessToken = token,
            RefreshToken = refreshToken.Token,
            ExpiresAt = DateTime.UtcNow.AddMinutes(30),
            Message = "Login successful"
        });
    }

    private async Task<string> GenerateJwtToken(ApplicationUser user)
    {
        var jwtSettings = new JwtSecurityTokenHandler();

        var jwtKey = Environment.GetEnvironmentVariable("GEARFORGEXI_JWT_KEY")
            ?? throw new Exception("GEARFORGEXI_JWT_KEY not set");

        var jwtIssuer = Environment.GetEnvironmentVariable("GEARFORGEXI_JWT_ISSUER")
            ?? throw new Exception("GEARFORGEXI_JWT_ISSUER not set");

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
            expires: DateTime.UtcNow.AddMinutes(30),
            signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256
            )
        );

        return jwtSettings.WriteToken(token);
    }

    private async Task<TokenResponseDto> GenerateTokenResponseAsync(ApplicationUser user)
    {
        var accessToken = await GenerateJwtToken(user);
        var refreshToken = await _refreshTokenService.GenerateRefreshTokenAsync(user.Id);
        var expiresAt = DateTime.UtcNow.AddMinutes(30); // Match the JWT expiration exactly

        return new TokenResponseDto
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken.Token,
            ExpiresAt = expiresAt,
            Message = "Authentication successful"
        };
    }

    [HttpPost("refresh")]
    public async Task<IActionResult> RefreshToken(RefreshTokenDto dto)
    {
        var refreshToken = await _refreshTokenService.GetValidRefreshTokenAsync(dto.RefreshToken);
        if (refreshToken == null)
            return Unauthorized("Invalid or expired refresh token");

        var user = refreshToken.User;

        // Revoke the used refresh token
        await _refreshTokenService.RevokeRefreshTokenAsync(dto.RefreshToken);

        // Generate new tokens
        var tokenResponse = await GenerateTokenResponseAsync(user);
        return Ok(tokenResponse);
    }

    [HttpPost("revoke")]
    public async Task<IActionResult> RevokeToken(RefreshTokenDto dto)
    {
        await _refreshTokenService.RevokeRefreshTokenAsync(dto.RefreshToken);
        return Ok(new { message = "Token revoked successfully" });
    }
}
