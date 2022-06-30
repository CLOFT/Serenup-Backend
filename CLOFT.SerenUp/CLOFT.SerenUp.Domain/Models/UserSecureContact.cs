namespace CLOFT.SerenUp.Domain.Models;

public class UserSecureContact
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string ContactEmail { get; set; }

    public UserSecureContact()
    {
    }
}