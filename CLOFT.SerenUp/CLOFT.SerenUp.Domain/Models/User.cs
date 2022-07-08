using RepoDb.Attributes;

namespace CLOFT.SerenUp.Domain.Models;

[Map("Users")]
public class User
{
    public User(string username)
    {
        Username = username;
    }

    public string Username { get; set; }
    public string Role { get; set; }
}