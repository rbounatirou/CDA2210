using Microsoft.EntityFrameworkCore;

namespace ApiUser.Models.Database
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer(@"Data Source = (localdb)\mssqllocaldb; Initial Catalog = db_cereals; Integrated Security = True");


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasIndex(user => user.Username).IsUnique();

        }
    }
}
