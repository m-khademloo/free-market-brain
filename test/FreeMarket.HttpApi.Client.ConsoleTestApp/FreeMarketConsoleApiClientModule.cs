using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace FreeMarket.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(FreeMarketHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class FreeMarketConsoleApiClientModule : AbpModule
    {
        
    }
}
