using FinancialTamkeen_BlogAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FinancialTamkeen_BlogAPI.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
        }

        DbSet<Product> Product { get; set; }
    }
}
