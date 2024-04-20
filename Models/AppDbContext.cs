using Microsoft.EntityFrameworkCore;

namespace mf_devbackend_2024.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Consumption> Consumptions { get; set; }

        public DbSet<User> Users { get; set; }

        public static void Seed(WebApplication application)
        {

            using (var scope = application.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                User admin = new User
                {
                    Id = 1,
                    Name = "Admin",
                    UserName = "admin",
                    Password = "$2a$10$ekA30WsbMQyQOJyJozk31eRathzdWM.PMuPS0FZ6ctTIH1Ajtl3Ny",
                    Profile = 0
                };

                context.Users.Add(admin);
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT mf-devbackend.Users ON;");
                context.SaveChanges();
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT mf-devbackend.Users OFF;");

            }
        }

    }
}
