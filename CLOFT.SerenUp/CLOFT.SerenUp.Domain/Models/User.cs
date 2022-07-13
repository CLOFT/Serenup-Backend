using System.Data;
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
    [TypeMap(DbType.DateTime2)] 
    public DateTime Birth { get; set; }
}