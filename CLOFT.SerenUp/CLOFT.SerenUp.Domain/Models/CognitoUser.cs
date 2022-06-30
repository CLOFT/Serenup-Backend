namespace CLOFT.SerenUp.Domain.Models;

public class CognitoUser
{
    public CognitoUser(string username)
    {
        Username = username;
    }

    public string Username { get; set; }
}