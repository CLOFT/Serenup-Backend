using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLOFT.SerenUp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlarmsController : ControllerBase
{
    private readonly IAlarmsService _alarmsService;

    public AlarmsController(IAlarmsService alarmsService)
    {
        _alarmsService = alarmsService;
    }

    // GET / 
    [HttpGet]
    public async Task<IEnumerable<Alarm>> GetAll()
    {
        var list = await _alarmsService.GetAllAlarmsAsync();
        return list;
    }

    // GET /Count
    [HttpGet("Count")]
    public async Task<long> Count()
    {
        var count = await _alarmsService.CountAlarmsAsync();
        return count;
    }

    // GET /LastDayCount
    [HttpGet("LastDayCount")]
    public async Task<long> LastDayCount()
    {
        var count = await _alarmsService.CountLastDayAlarmsAsync();
        return count;
    }

    // POST /
    [HttpPost]
    public async Task<ActionResult<Alarm>> Create(Alarm alarm)
    {
        var id = await _alarmsService.InsertAlarmAsync(alarm);
        if (id != null)
            return Ok(alarm);
        return null;
    }
}