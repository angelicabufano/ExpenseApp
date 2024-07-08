﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseApp.Models;

public class Expense {
    public int Id { get; set; }
    [StringLength(80)]
    public string Description { get; set; } = string.Empty;
    [StringLength(10)]
    public string Status { get; set; } = "NEW";
    [Column(TypeName = "decimal(11,2)")]
    public decimal Total { get; set; } = 0m;

    public int EmployeeId { get; set; }
    public virtual Employee? Employee { get; set; }

}
