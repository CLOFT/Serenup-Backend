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

    // POST 
    [HttpPost]
    public async Task<ActionResult<Bracelet>> Create(Bracelet bracelet)
    {
        var id = await _braceletsService.InsertBraceletAsync(bracelet);
        var result = await _braceletsService.GetBraceletAsync(id);
        return Ok(result);
    }
}