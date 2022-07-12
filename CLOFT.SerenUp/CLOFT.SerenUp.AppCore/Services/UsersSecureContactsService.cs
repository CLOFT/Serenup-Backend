using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Services;

public class UsersSecureContactsService : IUsersSecureContactsService
{
    private readonly IUsersSecureContactsRepository _usersSecureContactsRepository;

    public UsersSecureContactsService(IUsersSecureContactsRepository usersSecureContactsRepository)
    {
        _usersSecureContactsRepository = usersSecureContactsRepository;
    }

    public async Task<IEnumerable<UserSecureContact>> GetUserSecureContactsByUsernameAsync(string username)
    {
        var list = await _usersSecureContactsRepository.GetByUsername(username);
        return list;
    }

    public async Task<Guid> InsertUserSecureContactAsync(UserSecureContact entity)
    {
        var id = await _usersSecureContactsRepository.InsertAsync(entity);
        return id;
    }
}