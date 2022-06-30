using RepoDb.Attributes;

namespace CLOFT.SerenUp.Domain.Models;

[Map("CognitoUsers")]
public class CognitoUser
{
    public CognitoUser(string username)
    {
        Username = username;
    }

    public string Username { get; set; }
}