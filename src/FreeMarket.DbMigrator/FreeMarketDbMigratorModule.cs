using FreeMarket.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace FreeMarket.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FreeMarketEntityFrameworkCoreDbMigrationsModule),
        typeof(FreeMarketApplicationContractsModule)
        )]
    public class FreeMarketDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
