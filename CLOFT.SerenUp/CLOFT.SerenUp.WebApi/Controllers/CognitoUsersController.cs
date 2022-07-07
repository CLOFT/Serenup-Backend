using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLOFT.SerenUp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CognitoUsersController : ControllerBase
{
    private readonly ICognitoUsersService _cognitoUsersService;

    public CognitoUsersController(ICognitoUsersService cognitoUsersService)
    {
        _cognitoUsersService = cognitoUsersService;
    }
    
    // POST /
    [HttpPost]
    public async Task<ActionResult<CognitoUser>> Create(CognitoUser cognitoUser)
    {
        var id = await _cognitoUsersService.InsertUserAsync(cognitoUser);
        return cognitoUser;
    }
}