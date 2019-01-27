using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Net_Core_3_Postgre_Codefirst.Entities;
using System;

namespace Net_Core_3_Postgre_Codefirst.Context
{
    public class PostgreDbContext : DbContext
    {
        #region Constructor

        public PostgreDbContext(DbContextOptions<PostgreDbContext> options)
            : base(options)
        {

        }

        #endregion Constructor

        #region ModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        #endregion ModelCreating

        #region OnConfiguring

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
        }

        #endregion OnConfiguring

        #region DbSets

        public DbSet<EntityUser> EntityUser { get; set; }

        #endregion DbSets

    }
}
