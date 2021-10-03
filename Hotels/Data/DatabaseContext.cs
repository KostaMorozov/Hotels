using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
        : base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Israel",
                    ShortName = "IL"
                },
                new Country
                {
                    Id = 2,
                    Name = "United State",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 3,
                    Name = "France",
                    ShortName = "FR"
                }
            );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Americana",
                    Address = "Dead sea",
                    CountryId = 1,
                    Rating = 3.0
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Nirvana",
                    Address = "Nahariya",
                    CountryId = 2,
                    Rating = 4.0
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Isrotel",
                    Address = "Eilat",
                    CountryId = 3,
                    Rating = 5.0
                }
            );
        }

    }
}
