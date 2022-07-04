using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Interfaces.Services;

public interface IBraceletsService
{
    Task<IEnumerable<Bracelet>> GetAllBraceletsAsync();
    Task<Bracelet> GetBraceletAsync(Guid id);
    Task<Bracelet> GetBraceletByUsernameAsync(string username);
    Task<Guid> InsertBraceletAsync(Bracelet entity);
    Task<Guid> UpdateBraceletAsync(Bracelet entity);
}