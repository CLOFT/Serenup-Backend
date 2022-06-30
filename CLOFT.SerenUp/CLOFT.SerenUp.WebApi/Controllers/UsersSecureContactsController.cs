using CLOFT.SerenUp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLOFT.SerenUp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersSecureContactsController : ControllerBase
{
    // GET /username
    [HttpGet("{username}")]
    public Task<IEnumerable<UserSecureContact>> GetByUsername(string username)
    {
        var list = new List<UserSecureContact>();
        for (int i = 0; i < 3; i++)
        {
            list.Add(new UserSecureContact
            {
                Id = Guid.NewGuid(),
                Username = username,
                ContactEmail = $"testmail{i + 1}@fakemail.com"
            });
        }

        return Task.FromResult<IEnumerable<UserSecureContact>>(list);
    }
}