using System.Text.Json.Serialization;
using RepoDb.Attributes;

namespace CLOFT.SerenUp.Domain.Models;

[Map("Alarms")]
public class Alarm
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BraceletId { get; set; }
    public string Type { get; set; }
    public int? Value { get; set; }
    public DateTime Time { get; set; }

    public Alarm()
    {
    }
}