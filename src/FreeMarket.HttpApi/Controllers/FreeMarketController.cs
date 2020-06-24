using FreeMarket.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FreeMarket.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FreeMarketController : AbpController
    {
        protected FreeMarketController()
        {
            LocalizationResource = typeof(FreeMarketResource);
        }
    }
}