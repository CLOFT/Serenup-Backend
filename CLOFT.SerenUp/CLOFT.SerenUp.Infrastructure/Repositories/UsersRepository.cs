using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using RepoDb;

namespace CLOFT.SerenUp.Infrastructure.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly IConfiguration _configuration;

    public UsersRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task<IEnumerable<User>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<string> InsertAsync(User entity)
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.InsertAsync<User, string>(entity);
    }

    public Task<string> UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }
}