using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace FreeMarket.EntityFrameworkCore
{
    [DependsOn(
        typeof(FreeMarketEntityFrameworkCoreModule)
        )]
    public class FreeMarketEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FreeMarketMigrationsDbContext>();
        }
    }
}
