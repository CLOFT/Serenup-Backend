using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Interfaces.Repositories;

public interface IUsersSecureContactsRepository : IRepositoryBase<UserSecureContact, Guid>
{
    Task<IEnumerable<UserSecureContact>> GetByUsername(string username);
}