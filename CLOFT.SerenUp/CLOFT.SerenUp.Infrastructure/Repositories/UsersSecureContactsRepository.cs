using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using RepoDb;

namespace CLOFT.SerenUp.Infrastructure.Repositories;

public class UsersSecureContactsRepository : IUsersSecureContactsRepository
{
    private readonly IConfiguration _configuration;

    public UsersSecureContactsRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task<IEnumerable<UserSecureContact>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserSecureContact> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Guid> InsertAsync(UserSecureContact entity)
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.InsertAsync<UserSecureContact, Guid>(entity);
    }

    public Task<Guid> UpdateAsync(UserSecureContact entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<UserSecureContact>> GetByUsername(string username)
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.QueryAsync<UserSecureContact>(u => u.Username == username);
    }
}