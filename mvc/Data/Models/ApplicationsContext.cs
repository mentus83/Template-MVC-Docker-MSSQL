using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using mvc.Models.Entities;

namespace mvc.Data.Models
{
    public class ApplicationsContext : DbContext 
    {
        private readonly IConfiguration _config;

        public DbSet<NhApplcation> Applcations { get; set; }
        public ApplicationsContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            optionsBuilder.UseSqlServer(connectionString);
            // To Read From Config file: optionsBuilder.UseSqlServer(_config["ConnectionStrings:ApplicationContextDb"]);
        }

        /*
        To use HasData instead of Seeding at the Program start:
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<NhApplcation>()
            .HasData(new NhApplcation(){
                Id = 1,
                Name = "Charm",
                Version = "1.1.1"
            });
        }
        */
    }
}