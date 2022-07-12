using RepoDb.Attributes;

namespace CLOFT.SerenUp.Domain.Models;

[Map("UsersSecureContacts")]
public class UserSecureContact
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string ContactEmail { get; set; }

    public UserSecureContact()
    {
    }
}