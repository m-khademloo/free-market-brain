using FreeMarket.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FreeMarket
{
    [DependsOn(
        typeof(FreeMarketEntityFrameworkCoreTestModule)
        )]
    public class FreeMarketDomainTestModule : AbpModule
    {

    }
}