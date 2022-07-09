using RepoDb.Attributes;

namespace CLOFT.SerenUp.Domain.Models;

[Map("Bracelets")]
public class Bracelet
{
    public Guid SerialNumber { get; set; }
    public string? Username { get; set; }
    public int? Serendipity { get; set; }
    public string Color { get; set; }

    public Bracelet()
    {
    }
}