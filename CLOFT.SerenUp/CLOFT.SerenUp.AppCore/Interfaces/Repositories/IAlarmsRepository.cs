using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Interfaces.Repositories;

public interface IAlarmsRepository : IRepositoryBase<Alarm, Guid>
{
    Task<long> CountLastDayAsync();
}