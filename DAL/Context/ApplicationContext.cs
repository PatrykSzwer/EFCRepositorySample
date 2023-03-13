using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<FavoriteBeer> FavoriteBeers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call additional model builders here.
            base.OnModelCreating(modelBuilder);
        }
    }
}
