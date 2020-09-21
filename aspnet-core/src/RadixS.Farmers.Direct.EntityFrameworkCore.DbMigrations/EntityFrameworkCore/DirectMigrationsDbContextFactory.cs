using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RadixS.Farmers.Direct.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class DirectMigrationsDbContextFactory : IDesignTimeDbContextFactory<DirectMigrationsDbContext>
    {
        public DirectMigrationsDbContext CreateDbContext(string[] args)
        {
            DirectEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DirectMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new DirectMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../RadixS.Farmers.Direct.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
