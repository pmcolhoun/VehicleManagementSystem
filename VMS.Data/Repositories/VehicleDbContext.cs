using System;
using VMS.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace VMS.Data.Repositories
{
    public class VehicleDbContext : DbContext
    {
        //DbSets for Vehicles and Servies
        public DbSet<Vehicle> Vehicles {get; set;}

        public DbSet<Service> Services {get; set;}

        //OnConfigure method to set up SQLite database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=VMS.db");
        }

        //Method to recreate the database, ensuring the new database takes account
        //of any changes to the Models or DatabaseContext
        public void Initialise()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        // Creates a Sql Query console logger that can be added to context for debugging
        private static ILoggerFactory GetConsoleLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder => builder.AddConsole()
                .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information)
            );
            return serviceCollection.BuildServiceProvider()
                .GetService<ILoggerFactory>();
        }
        
    }
}