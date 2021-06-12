using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using mvc.Models.Entities;

namespace mvc.Data.Models
{
    public class MyObjectContext : DbContext 
    {
        private readonly IConfiguration _config;

        public DbSet<MyObject> MyObjects { get; set; }
        public DbSet<MyObjectItem> MyObjectItems { get; set; }
        public MyObjectContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING")?? 
                Environment.GetEnvironmentVariable("DB_CONNECTION_STRING", EnvironmentVariableTarget.User);
            
            optionsBuilder.UseSqlServer(connectionString);
            // To Read From Config file: optionsBuilder.UseSqlServer(_config["ConnectionStrings:ApplicationContextDb"]);
        }

        /*
        To use HasData instead of Seeding at the Program start:
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<MyObject>()
            .HasData(new MyObject(){
                Id = 1,
                Name = "val1",
                Description = "val2"
            });
        }
        */
    }
}