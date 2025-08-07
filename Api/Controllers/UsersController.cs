using FFXIComp.Api.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FFXIComp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] // All endpoints require authentication
public class UsersController(
    UserManager<IdentityUser> userManager
) : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager = userManager;

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetUsers()
    {
        var users = _userManager.Users.ToList();
        var userList = new List<object>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            userList.Add(new
            {
                user.Id,
                user.Email,
                user.UserName,
                Roles = roles
            });
        }

        return Ok(userList);
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
            return NotFound("User not found");

        var roles = await _userManager.GetRolesAsync(user);

        return Ok(new
        {
            user.Id,
            user.Email,
            user.UserName,
            Roles = roles
        });
    }

    [HttpPost("{id}/roles")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> AddRoleToUser(string id, [FromBody] RoleActionDto dto)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
            return NotFound("User not found");

        // Validate role exists
        if (dto.RoleName != "Admin" && dto.RoleName != "User")
            return BadRequest("Invalid role. Valid roles are: Admin, User");

        // Check if user already has this role
        if (await _userManager.IsInRoleAsync(user, dto.RoleName))
            return BadRequest($"User already has the {dto.RoleName} role");

        var result = await _userManager.AddToRoleAsync(user, dto.RoleName);
        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok($"Role '{dto.RoleName}' added to user {user.Email}");
    }

    [HttpDelete("{id}/roles/{roleName}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> RemoveRoleFromUser(string id, string roleName)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
            return NotFound("User not found");

        // Validate role exists
        if (roleName != "Admin" && roleName != "User")
            return BadRequest("Invalid role. Valid roles are: Admin, User");

        // Check if user has this role
        if (!await _userManager.IsInRoleAsync(user, roleName))
            return BadRequest($"User does not have the {roleName} role");

        // Prevent removing the last admin
        if (roleName == "Admin")
        {
            var admins = await _userManager.GetUsersInRoleAsync("Admin");
            if (admins.Count <= 1)
                return BadRequest("Cannot remove the last admin user");
        }

        var result = await _userManager.RemoveFromRoleAsync(user, roleName);
        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok($"Role '{roleName}' removed from user {user.Email}");
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
            return NotFound("User not found");

        // Prevent deleting the last admin
        if (await _userManager.IsInRoleAsync(user, "Admin"))
        {
            var admins = await _userManager.GetUsersInRoleAsync("Admin");
            if (admins.Count <= 1)
                return BadRequest("Cannot delete the last admin user");
        }

        var result = await _userManager.DeleteAsync(user);
        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok($"User {user.Email} has been deleted");
    }
}
