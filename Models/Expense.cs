using System;

public enum ExpenseType
{
    Travel,
    Food,
    Supplies,
    Utilities,
    Miscellaneous,
    Rent
}

public class Expense
{
    public Guid Id { get; set; }
    public required ExpenseType TypeOfExpense { get; set; }
    public required decimal Amount { get; set; }
    public Guid UserId { get; set; }
    public required UserAccount UserAccount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
