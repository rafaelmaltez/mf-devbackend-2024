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
                var adminAlreadySeeded = context.Users.FirstOrDefault<User>(user => user.UserName == "admin");
                if (adminAlreadySeeded != null)
                {
                    return;
                }
                User admin = new User
                {
                    Name = "Admin",
                    UserName = "admin",
                    Password = "$2a$10$ekA30WsbMQyQOJyJozk31eRathzdWM.PMuPS0FZ6ctTIH1Ajtl3Ny",
                    Profile = 0
                };
                context.Users.Add(admin);
                context.SaveChanges();
            }
        }

    }
}
