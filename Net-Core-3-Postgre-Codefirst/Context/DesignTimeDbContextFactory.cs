using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Net_Core_3_Postgre_Codefirst.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PostgreDbContext>
    {
        public PostgreDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<PostgreDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseNpgsql(connectionString);
            return new PostgreDbContext(builder.Options);
        }
    }
}
