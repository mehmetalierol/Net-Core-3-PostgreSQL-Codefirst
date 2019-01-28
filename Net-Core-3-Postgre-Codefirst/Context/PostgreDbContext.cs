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

        }

        #endregion OnConfiguring

        #region DbSets

        public DbSet<EntityUser> EntityUser { get; set; }

        #endregion DbSets

    }
}
