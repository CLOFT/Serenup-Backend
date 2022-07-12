using CLOFT.SerenUp.Domain.Models;

namespace CLOFT.SerenUp.AppCore.Interfaces.Services;

public interface IUsersSecureContactsService
{
    Task<IEnumerable<UserSecureContact>> GetUserSecureContactsByUsernameAsync(string username);
    Task<Guid> InsertUserSecureContactAsync(UserSecureContact entity);
}