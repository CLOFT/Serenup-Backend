using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLOFT.SerenUp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }
    
    // POST /
    [HttpPost]
    public async Task<ActionResult<User>> Create(User user)
    {
        var id = await _usersService.InsertUserAsync(user);
        return user;
    }
}