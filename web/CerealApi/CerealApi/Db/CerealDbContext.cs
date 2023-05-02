using CerealApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CerealApi.Db
{
    public class CerealDbContext : DbContext
    {

        public DbSet<Cereal> Cereals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilders)
        {
            base.OnConfiguring(optionsBuilders);
            
            optionsBuilders.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_cereals");

        }
    }
}
