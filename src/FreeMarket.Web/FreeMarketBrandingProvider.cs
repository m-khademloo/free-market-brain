using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace FreeMarket.Web
{
    [Dependency(ReplaceServices = true)]
    public class FreeMarketBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FreeMarket";
    }
}
