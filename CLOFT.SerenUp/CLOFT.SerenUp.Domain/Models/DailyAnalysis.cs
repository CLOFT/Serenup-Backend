using RepoDb.Attributes;

namespace CLOFT.SerenUp.Domain.Models;

[Map("DailyAnalyses")]
public class DailyAnalysis
{
    public Guid Id { get; set; }
    public int? BraceletsCount { get; set; }
    public int? UsersCount { get; set; }
    public int? AdminCount { get; set; }
    
    public DailyAnalysis()
    {
        
    }
}