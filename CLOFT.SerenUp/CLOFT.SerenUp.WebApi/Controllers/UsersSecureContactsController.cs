using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLOFT.SerenUp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UsersSecureContactsController : ControllerBase
{
    private readonly IUsersSecureContactsService _usersSecureContactsService;

    public UsersSecureContactsController(IUsersSecureContactsService usersSecureContactsService)
    {
        _usersSecureContactsService = usersSecureContactsService;
    }
    
    // GET /{username}
    [HttpGet("{username}")]
    public async Task<IEnumerable<UserSecureContact>> GetUserSecureContactsByUsername(string username)
    {
        var secureContacts = await _usersSecureContactsService.GetUserSecureContactsByUsernameAsync(username);
        return secureContacts;
    }
    
    // POST /
    [HttpPost]
    public async Task<Guid> CreateUserSecureContact(UserSecureContact model)
    {
        var id = await _usersSecureContactsService.InsertUserSecureContactAsync(model);
        return id;
    }
}