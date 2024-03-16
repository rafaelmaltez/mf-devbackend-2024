using Microsoft.EntityFrameworkCore;

namespace mf_devbackend_2024.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Consumption> Consumptions { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
