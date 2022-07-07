using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.Domain.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using RepoDb;

namespace CLOFT.SerenUp.Infrastructure.Repositories;

public class AlarmsRepository : IAlarmsRepository
{
    private readonly IConfiguration _configuration;

    public AlarmsRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IEnumerable<Alarm>> GetAllAsync()
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.QueryAllAsync<Alarm>();
    }

    public Task<Alarm> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Guid> InsertAsync(Alarm entity)
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.InsertAsync<Alarm, Guid>(entity);
    }

    public Task<Guid> UpdateAsync(Alarm entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<long> CountAsync()
    {
        var cs = _configuration.GetSection("ConnectionString").Value;
        using var DB = new NpgsqlConnection(cs);
        return await DB.CountAllAsync<Alarm>();
    }
}