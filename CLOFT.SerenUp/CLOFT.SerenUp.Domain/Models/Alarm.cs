﻿namespace CLOFT.SerenUp.Domain.Models;

public class Alarm
{
    public Guid Id { get; set; }
    public Guid BraceletId { get; set; }
    public string Type { get; set; }
    public int? Value { get; set; }
    public DateTime Timestamp { get; set; }
    
    public Alarm()
    {
        
    }
}