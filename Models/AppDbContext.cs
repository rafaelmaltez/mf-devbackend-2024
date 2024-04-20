using Microsoft.EntityFrameworkCore;

namespace mf_devbackend_2024.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Consumption> Consumptions { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Admin",
                    UserName = "admin",
                    Password = "$2a$10$ekA30WsbMQyQOJyJozk31eRathzdWM.PMuPS0FZ6ctTIH1Ajtl3Ny",
                    Profile = 0
                }
            );
        }
    }
}
