using CLOFT.SerenUp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLOFT.SerenUp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BraceletsController : ControllerBase
{
    // GET /id
    [HttpGet("{id}")]
    public Task<Bracelet> GetById(Guid id)
    {
        return Task.FromResult(new Bracelet
        {
            SerialNumber = id,
            Color = "red",
            Username = "test"
        });
    }
}