using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace FreeMarket
{
    public class FreeMarketWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<FreeMarketWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}