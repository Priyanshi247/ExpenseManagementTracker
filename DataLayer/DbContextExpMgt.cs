using ExpenseManagement.Models;

using Microsoft.Identity.Client;
using System.Data.Entity;

namespace ExpenseManagement.DataLayer
{
    public class DbContextExpMgt : DbContext
    {
        public DbContextExpMgt(DbContextOptions options): base(options) { }
        {
            
        }
        //public DbContextExpMgt(DbContextOptions options) : base(options)
        //{

        //}

        public DbSet<ExpenseEntity> Expenses { get; set; }
        public DbSet<ExpenseCategoryEntity> ExpenseCategory { get; set; }

        public DbSet<UserProfile> UserProfile { get; set; }
    }
}
