using Bayolu.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bayolu.AppService.Infastructure
{
    public class BayolyDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public BayolyDbContext(DbContextOptions<BayolyDbContext> options) : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
