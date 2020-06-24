using FreeMarket.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FreeMarket.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class FreeMarketPageModel : AbpPageModel
    {
        protected FreeMarketPageModel()
        {
            LocalizationResourceType = typeof(FreeMarketResource);
        }
    }
}