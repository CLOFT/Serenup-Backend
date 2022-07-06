using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Interfaces.Services;

public interface IAlarmsService
{
    Task<IEnumerable<Alarm>> GetAllAlarmsAsync();
    Task<Guid> InsertAlarmAsync(Alarm entity);
    Task<long> CountAlarmsAsync();
}