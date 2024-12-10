using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class UserAccount
{
    [Key]
    public Guid UserId { get; set; }
    [Required]
    [MaxLength(50)]
    public required string Name { get; set; }
    [Required]
    [MaxLength(50)]
    public required string Surname { get; set; }
    [Required]
    [EmailAddress]
    public required string Email { get; set; }
    [Required]
    [MinLength(8)]
    public required string Password { get; set; }
    public string? Address { get; set; }
    public required ICollection<Expense> Expenses { get; set; }
    public required ICollection<Income> Incomes { get; set; }
}