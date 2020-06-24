using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FreeMarket.Data
{
    /* This is used if database provider does't define
     * IFreeMarketDbSchemaMigrator implementation.
     */
    public class NullFreeMarketDbSchemaMigrator : IFreeMarketDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}