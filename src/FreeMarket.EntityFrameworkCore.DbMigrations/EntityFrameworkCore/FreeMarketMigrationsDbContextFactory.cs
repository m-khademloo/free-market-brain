﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FreeMarket.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class FreeMarketMigrationsDbContextFactory : IDesignTimeDbContextFactory<FreeMarketMigrationsDbContext>
    {
        public FreeMarketMigrationsDbContext CreateDbContext(string[] args)
        {
            FreeMarketEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<FreeMarketMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new FreeMarketMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}