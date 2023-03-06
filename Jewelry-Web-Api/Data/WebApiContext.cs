using Jewelry_Web_Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Jewelry_Web_Api.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options) { }

        public DbSet<Ring> Rings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ring>()
                .Property(r => r.Price)
                .HasColumnType("decimal(18, 2)");
        }
    }
}
