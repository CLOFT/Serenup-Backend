using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using RepoDb;

namespace CLOFT.SerenUp.Infrastructure.Repositories;

public class CognitoUsersRepository : ICognitoUsersRepository
{
    private readonly IConfiguration _configuration;

    public CognitoUsersRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task<IEnumerable<CognitoUser>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CognitoUser> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<string> InsertAsync(CognitoUser entity)
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.InsertAsync<CognitoUser, string>(entity);
    }

    public Task<string> UpdateAsync(CognitoUser entity)
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