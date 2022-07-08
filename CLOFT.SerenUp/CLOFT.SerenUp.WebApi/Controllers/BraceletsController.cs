using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLOFT.SerenUp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BraceletsController : ControllerBase
{
    private readonly IBraceletsService _braceletsService;

    public BraceletsController(IBraceletsService braceletsService)
    {
        _braceletsService = braceletsService;
    }

    // GET /
    [HttpGet]
    public async Task<IEnumerable<Bracelet>> Get()
    {
        var bracelets = await _braceletsService.GetAllBraceletsAsync();
        return bracelets;
    }

    // GET /id
    [HttpGet("{id}")]
    public async Task<Bracelet> GetById(Guid id)
    {
        var result = await _braceletsService.GetBraceletAsync(id);
        return result;
    }

    // GET /GetByUsername/username
    [HttpGet("GetByUsername/{username}")]
    public async Task<Bracelet> GetByUsername(string username)
    {
        var result = await _braceletsService.GetBraceletByUsernameAsync(username);
        return result;
    }

    // POST 
    [HttpPost]
    public async Task<ActionResult<Bracelet>> Create(Bracelet bracelet)
    {
        var id = await _braceletsService.InsertBraceletAsync(bracelet);
        var result = await _braceletsService.GetBraceletAsync(id);
        return Ok(result);
    }

    // PUT
    [HttpPut]
    public async Task<ActionResult<Guid>> Update(Bracelet bracelet)
    {
        var id = await _braceletsService.UpdateBraceletAsync(bracelet);
        return StatusCode(202, id);
    }
}