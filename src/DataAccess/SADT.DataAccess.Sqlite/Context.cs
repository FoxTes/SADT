using Microsoft.EntityFrameworkCore;
using SADT.Core.Enums;
using SADT.DataAccess.Sqlite.Entitys;
using SADT.DataAccess.Sqlite.Entitys.Wire;
using System;

namespace SADT.DataAccess.Sqlite
{
    public class Context : DbContext
    {
        public DbSet<Wire> Wires { get; set; }

        public DbSet<LastProject> LastProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PressurePoint>().HasData(
                new PressurePoint { Id = 1, Pressure = 10, WireId = 1 },
                new PressurePoint { Id = 2, Pressure = 20, WireId = 1 },
                new PressurePoint { Id = 3, Pressure = 30, WireId = 1 },
                new PressurePoint { Id = 4, Pressure = 40, WireId = 1 },
                new PressurePoint { Id = 5, Pressure = 50, WireId = 1 },
                new PressurePoint { Id = 6, Pressure = 60, WireId = 1 });

            modelBuilder.Entity<Wire>().HasData(
                new Wire
                {
                    Id = 1,
                    Name = "Первый",
                });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlite($"Data Source=app.db");
    }
}
