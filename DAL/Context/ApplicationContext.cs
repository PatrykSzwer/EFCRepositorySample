using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Beer> Beers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call additional model builders here.
            base.OnModelCreating(modelBuilder);
        }
    }
}
