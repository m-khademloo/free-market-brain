using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace FreeMarket.EntityFrameworkCore
{
    public static class FreeMarketDbContextModelCreatingExtensions
    {
        public static void ConfigureFreeMarket(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FreeMarketConsts.DbTablePrefix + "YourEntities", FreeMarketConsts.DbSchema);

            //    //...
            //});
        }
    }
}