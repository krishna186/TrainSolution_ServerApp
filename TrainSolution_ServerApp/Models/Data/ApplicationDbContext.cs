using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace TrainSolution_ServerApp.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Using Entity Framework Core to manage the database context for the train management system.
        // Created Database using Migration command: Add-Migration InitialCreate,UpdateDatabase 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Trains> Trains { get; set; }
        public DbSet<TrainComponents> TrainComponents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TrainComponents>().ToTable("Components");
            modelBuilder.Entity<Trains>()
                .HasKey(t => t.VehicleNumber);
            modelBuilder.Entity<TrainComponents>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Trains>().HasData(
         new Trains { VehicleNumber = "VH001", FleetName = "Fleet A", DateIntoService = new DateTime(2000, 1, 1), DateEndsService = new DateTime(2030, 12, 31) },
         new Trains { VehicleNumber = "VH002", FleetName = "Fleet A", DateIntoService = new DateTime(2000, 3, 15), DateEndsService = new DateTime(2031, 3, 15) },
         new Trains { VehicleNumber = "VH003", FleetName = "Fleet B", DateIntoService = new DateTime(2020, 6, 1), DateEndsService = new DateTime(2050, 6, 1) },
         new Trains { VehicleNumber = "VH004", FleetName = "Fleet B", DateIntoService = new DateTime(2020, 11, 20), DateEndsService = new DateTime(2050, 11, 20) },
         new Trains { VehicleNumber = "VH005", FleetName = "Fleet C", DateIntoService = new DateTime(2018, 8, 10), DateEndsService = new DateTime(2031, 8, 10) },
         new Trains { VehicleNumber = "VH006", FleetName = "Fleet C", DateIntoService = new DateTime(2018, 5, 5), DateEndsService = new DateTime(2031, 5, 5) },
         new Trains { VehicleNumber = "VH007", FleetName = "Fleet D", DateIntoService = new DateTime(1994, 2, 1), DateEndsService = new DateTime(2026, 2, 1) },
         new Trains { VehicleNumber = "VH008", FleetName = "Fleet D", DateIntoService = new DateTime(1994, 2, 1), DateEndsService = new DateTime(2026, 2, 1) },
         new Trains { VehicleNumber = "VH009", FleetName = "Fleet A", DateIntoService = new DateTime(2000, 9, 1), DateEndsService = new DateTime(2030, 9, 1) },
         new Trains { VehicleNumber = "VH010", FleetName = "Fleet B", DateIntoService = new DateTime(2020, 1, 1), DateEndsService = new DateTime(2050, 1, 1) }
     );
        }
    }
}
