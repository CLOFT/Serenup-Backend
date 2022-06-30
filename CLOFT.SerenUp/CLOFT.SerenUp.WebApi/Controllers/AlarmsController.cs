using CLOFT.SerenUp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLOFT.SerenUp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlarmsController : ControllerBase
{
    // POST /
    [HttpPost]
    public Task<IActionResult> Create(Alarm alarm)
    {
        // MOCK Insert
        var list = new List<Alarm> {alarm};
        return Task.FromResult<IActionResult>(Ok(alarm));
    }
}