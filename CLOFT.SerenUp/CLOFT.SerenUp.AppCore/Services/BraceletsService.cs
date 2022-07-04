using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Services;

public class BraceletsService : IBraceletsService
{
    private readonly IBraceletsRepository _braceletsRepository;

    public BraceletsService(IBraceletsRepository braceletsRepository)
    {
        _braceletsRepository = braceletsRepository;
    }

    public Task<IEnumerable<Bracelet>> GetAllBraceletsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Bracelet> GetBraceletAsync(Guid id)
    {
        var bracelet = await _braceletsRepository.GetAsync(id);
        return bracelet;
    }

    public async Task<Bracelet> GetBraceletByUsernameAsync(string username)
    {
        var bracelet = await _braceletsRepository.GetByUsernameAsync(username);
        return bracelet;
    }

    public Task<Guid> InsertBraceletAsync(Bracelet entity)
    {
        try
        {
            var id = _braceletsRepository.InsertAsync(entity);
            return id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public Task<Guid> UpdateBraceletAsync(Bracelet entity)
    {
        throw new NotImplementedException();
    }
}