using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreetOutlaws.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace StreetOutlaws.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Track> Tracks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Team>().HasData(
                new Team{
                    Id=1,
                    Name="Fire",
                },
                new Team{
                    Id=2,
                    Name="Water",
                },
                new Team{
                    Id=3,
                    Name="Wind",
                },
                new Team{
                    Id=4,
                    Name="Earth",
                }
            );
            modelBuilder.Entity<Driver>().HasData(
                new Driver{
                    Id=1,
                    Name="DeJuan Colbert",
                    TeamId=1
                },
                new Driver{
                    Id=2,
                    Name="Zachary Himes",
                    TeamId=1
                },
                new Driver{
                    Id=3,
                    Name="Jordan Hershberger",
                    TeamId=1
                },
                new Driver{
                    Id=4,
                    Name="Brody Hinton",
                    TeamId=1
                },
                new Driver{
                    Id=5,
                    Name="Darneisha Miller",
                    TeamId=2
                },
                new Driver{
                    Id=6,
                    Name="Cory Smith",
                    TeamId=2
                },
                new Driver{
                    Id=7,
                    Name="Jamie Coakley",
                    TeamId=2
                },
                new Driver{
                    Id=8,
                    Name="Michael Kinsey",
                    TeamId=2
                },
                new Driver{
                    Id=9,
                    Name="Celio Arias",
                    TeamId=3
                },
                new Driver{
                    Id=10,
                    Name="Cassandra Emery",
                    TeamId=3
                },
                new Driver{
                    Id=11,
                    Name="Catlin Simon",
                    TeamId=3
                },
                new Driver{
                    Id=12,
                    Name="Terry Brown",
                    TeamId=3
                },
                new Driver{
                    Id=13,
                    Name="Nelson Fant IV",
                    TeamId=4
                },
                new Driver{
                    Id=14,
                    Name="Charles Lipperd",
                    TeamId=4
                },
                new Driver{
                    Id=15,
                    Name="Adam Lair",
                    TeamId=4
                },
                new Driver{
                    Id=16,
                    Name="Katelyn Hedlund",
                    TeamId=4
                }
            );
            modelBuilder.Entity<Car>().HasData(
                new Car{
                    Id=1,
                    Make="Pontiac",
                    Model="GTO",
                    Year=1970,
                    DriverId=1,
                },
                new Car{
                    Id=2,
                    Make="Chevy",
                    Model="Camero",
                    Year= 1969,
                    DriverId=2,
                },
                new Car{
                    Id=3,
                    Make="Chevy",
                    Model="Camero",
                    Year= 1999,
                    DriverId=3,
                },
                new Car{
                    Id=4,
                    Make="Chevy",
                    Model="Camero",
                    Year= 2010,
                    DriverId=4,
                },
                new Car{
                    Id=5,
                    Make="Chevrolet",
                    Model="Chevy II Nova",
                    Year= 1963,
                    DriverId=5,
                },
                new Car{
                    Id=6,
                    Make="Chevrolet",
                    Model="Chevy II Nova",
                    Year= 1965,
                    DriverId=6,
                },
                new Car{
                    Id=7,
                    Make="Chevrolet",
                    Model="El Camino",
                    Year= 1969,
                    DriverId=7,
                },
                new Car{
                    Id=8,
                    Make="Chevrolet",
                    Model="El Camino",
                    Year= 1981,
                    DriverId=8,
                },
                new Car{
                    Id=9,
                    Make="Pontiac",
                    Model="LeMans",
                    Year=1969,
                    DriverId=9,
                },
                new Car{
                    Id=10,
                    Make="Pontiac",
                    Model="LeMans",
                    Year=1972,
                    DriverId=10,
                },
                new Car{
                    Id=11,
                    Make="Chevrolet",
                    Model="Vega",
                    Year= 1977,
                    DriverId=11,
                },
                new Car{
                    Id=12,
                    Make="Chevrolet",
                    Model="C10",
                    Year= 1970,
                    DriverId=12
                },
                new Car{
                    Id=13,
                    Make="Chevrolet",
                    Model="Monte Carlo",
                    Year= 1971,
                    DriverId=13,
                },
                new Car{
                    Id=14,
                    Make="Dodge",
                    Model="Dart",
                    Year= 1967,
                    DriverId=14,
                },
                new Car{
                    Id=15,
                    Make="Ford",
                    Model="Mustang",
                    Year= 1981,
                    DriverId=15,
                },
                new Car{
                    Id=16,
                    Make="Ford",
                    Model="Mustang",
                    Year= 2010,
                    DriverId=16,
                }
            );
        } 
    }
}