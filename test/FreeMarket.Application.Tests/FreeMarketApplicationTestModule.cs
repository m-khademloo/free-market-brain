using Volo.Abp.Modularity;

namespace FreeMarket
{
    [DependsOn(
        typeof(FreeMarketApplicationModule),
        typeof(FreeMarketDomainTestModule)
        )]
    public class FreeMarketApplicationTestModule : AbpModule
    {

    }
}