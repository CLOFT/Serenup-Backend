using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using RepoDb;

namespace CLOFT.SerenUp.Infrastructure.Repositories;

public class BraceletsRepository : IBraceletsRepository
{
    private readonly IConfiguration _configuration;

    public BraceletsRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IEnumerable<Bracelet>> GetAllAsync()
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.QueryAllAsync<Bracelet>();
    }

    public async Task<Bracelet> GetAsync(Guid id)
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return (await DB.QueryAsync<Bracelet>(b => b.SerialNumber == id)).FirstOrDefault();
    }

    public async Task<Guid> InsertAsync(Bracelet entity)
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.InsertAsync<Bracelet, Guid>(entity);
    }

    public async Task<Guid> UpdateAsync(Bracelet entity)
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return (await DB.UpdateAsync(entity) > 0) ? entity.SerialNumber : Guid.Empty;
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<long> CountAsync()
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.CountAllAsync<Bracelet>();
    }

    public async Task<Bracelet> GetByUsernameAsync(string username)
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return (await DB.QueryAsync<Bracelet>(b => b.Username == username)).FirstOrDefault();
    }
}