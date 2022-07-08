using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Services;

public class UsersService : IUsersService
{
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        var list = await _usersRepository.GetAllAsync();
        return list;
    }

    public async Task<string> InsertUserAsync(User entity)
    {
        var id = await _usersRepository.InsertAsync(entity);
        return id;
    }
}