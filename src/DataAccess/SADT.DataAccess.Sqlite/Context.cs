using Microsoft.EntityFrameworkCore;
using SADT.DataAccess.Sqlite.Entitys;
using SADT.DataAccess.Sqlite.Entitys.Wire;

namespace SADT.DataAccess.Sqlite
{
    public class Context : DbContext
    {
        public DbSet<Wire> Wires { get; set; }

        public DbSet<PressurePoint> PressurePoints { get; set; }

        public DbSet<LastProject> LastProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PressurePoint>().HasData(
                new PressurePoint { Id = 1, Pressure = 10, WireId = 1 },
                new PressurePoint { Id = 2, Pressure = 20, WireId = 1 },
                new PressurePoint { Id = 3, Pressure = 30, WireId = 1 },
                new PressurePoint { Id = 4, Pressure = 40, WireId = 1 },
                new PressurePoint { Id = 5, Pressure = 50, WireId = 1 },
                new PressurePoint { Id = 6, Pressure = 60, WireId = 1 },
                new PressurePoint { Id = 7, Pressure = 10, WireId = 2 },
                new PressurePoint { Id = 8, Pressure = 20, WireId = 2 },
                new PressurePoint { Id = 9, Pressure = 30, WireId = 2 },
                new PressurePoint { Id = 10, Pressure = 40, WireId = 2 },
                new PressurePoint { Id = 11, Pressure = 50, WireId = 2 },
                new PressurePoint { Id = 12, Pressure = 60, WireId = 2 });

            modelBuilder.Entity<Wire>().HasData(
                new Wire
                {
                    Id = 1,
                    Name = "АПБ"
                });

            modelBuilder.Entity<Wire>().HasData(
                new Wire
                {
                    Id = 2,
                    Name = "АВГ"
                });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlite($"Data Source=app.db");
    }
}
