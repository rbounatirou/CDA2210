using ApiBank.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBank.Databases
{
    public class BankDbContext
    {
        public DbSet<BankTransaction> BankTransactions { get; set; }

        /*protected override void OnModelCreating(DbContextOptionsBuilder builder)
        {
            base.
        }*/
    }
}