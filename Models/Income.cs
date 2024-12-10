using System;

public enum IncomeType
{
    Salary,          
    Business,        
    Investments,     
    GovernmentAid,   
    Other
}

public class Income
{
    public Guid Id { get; set; }
    public IncomeType TypeOfIncome { get; set; }
    public required decimal Amount { get; set; }
    public Guid UserId { get; set; }
    public required UserAccount UserAccount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string? Description { get; set; }
}
