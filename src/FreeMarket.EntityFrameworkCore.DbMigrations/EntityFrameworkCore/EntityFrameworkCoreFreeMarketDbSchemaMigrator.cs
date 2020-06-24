using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FreeMarket.Data;
using Volo.Abp.DependencyInjection;

namespace FreeMarket.EntityFrameworkCore
{
    public class EntityFrameworkCoreFreeMarketDbSchemaMigrator
        : IFreeMarketDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFreeMarketDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FreeMarketMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FreeMarketMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}