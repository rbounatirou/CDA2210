using ApiBank.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBank.Databases
{
    public class BankDbContext : DbContext
    {
        public DbSet<BankTransaction> BankTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=tp_banks");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<BankTransaction>().Property(b => b.TransactionDate).HasPrecision(3);
        }
    }
}