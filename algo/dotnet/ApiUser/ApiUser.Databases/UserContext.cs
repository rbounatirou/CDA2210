using ApiUser.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiUser.Databases
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=user_api");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasIndex(user => user.Username).IsUnique();

        }
    }
}
