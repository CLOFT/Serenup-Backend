using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Services;

public class AlarmsService : IAlarmsService
{
    private readonly IAlarmsRepository _alarmsRepository;

    public AlarmsService(IAlarmsRepository alarmsRepository)
    {
        _alarmsRepository = alarmsRepository;
    }

    public async Task<IEnumerable<Alarm>> GetAllAlarmsAsync()
    {
        var list = await _alarmsRepository.GetAllAsync();
        return list;
    }

    public async Task<Guid> InsertAlarmAsync(Alarm entity)
    {
        var id = await _alarmsRepository.InsertAsync(entity);
        return id;
    }

    public async Task<long> CountAlarmsAsync()
    {
        var count = await _alarmsRepository.CountAsync();
        return count;
    }
}