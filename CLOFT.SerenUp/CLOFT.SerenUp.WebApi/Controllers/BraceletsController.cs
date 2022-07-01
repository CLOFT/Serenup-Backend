using CLOFT.SerenUp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLOFT.SerenUp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BraceletsController : ControllerBase
{
    private readonly string[] _colors = {"red", "green", "black"};
    public const int BRACELETS_NUMBER = 100;

// GET /
    [HttpGet]
    public Task<IEnumerable<Bracelet>> Get()
    {
        // MOCK Bracelets
        var list = new List<Bracelet>();
        for (int i = 0; i < BRACELETS_NUMBER; i++)
        {
            list.Add(new Bracelet
            {
                Color = _colors[new Random().Next(3)],
                SerialNumber = Guid.NewGuid()
            });
        }

        return Task.FromResult<IEnumerable<Bracelet>>(list);
    }

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