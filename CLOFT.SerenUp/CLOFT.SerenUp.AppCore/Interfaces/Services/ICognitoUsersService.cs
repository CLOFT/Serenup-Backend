using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Interfaces.Services;

public interface ICognitoUsersService
{
    Task<string> InsertUserAsync(CognitoUser entity);
}