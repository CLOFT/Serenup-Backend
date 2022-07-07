using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Interfaces.Services;

public interface IUsersService
{
    Task<string> InsertUserAsync(User entity);
}