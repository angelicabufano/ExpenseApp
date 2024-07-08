using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExpenseApp.Models;

namespace ExpenseApp.Data
{
    public class ExpenseAppContext : DbContext
    {
        public ExpenseAppContext (DbContextOptions<ExpenseAppContext> options)
            : base(options)
        {
        }

        public DbSet<ExpenseApp.Models.Employee> Employee { get; set; } = default!;
        public DbSet<ExpenseApp.Models.Expense> Expense { get; set; } = default!;
    }
}
