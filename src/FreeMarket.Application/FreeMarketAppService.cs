using System;
using System.Collections.Generic;
using System.Text;
using FreeMarket.Localization;
using Volo.Abp.Application.Services;

namespace FreeMarket
{
    /* Inherit your application services from this class.
     */
    public abstract class FreeMarketAppService : ApplicationService
    {
        protected FreeMarketAppService()
        {
            LocalizationResource = typeof(FreeMarketResource);
        }
    }
}
