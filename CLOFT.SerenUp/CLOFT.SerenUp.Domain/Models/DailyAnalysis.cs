namespace CLOFT.SerenUp.Domain.Models;

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