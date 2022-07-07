using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Services;

public class CognitoUsersService : ICognitoUsersService
{
    private readonly ICognitoUsersRepository _cognitoUsersRepository;

    public CognitoUsersService(ICognitoUsersRepository cognitoUsersRepository)
    {
        _cognitoUsersRepository = cognitoUsersRepository;
    }

    public async Task<string> InsertUserAsync(CognitoUser entity)
    {
        var id = await _cognitoUsersRepository.InsertAsync(entity);
        return id;
    }
}