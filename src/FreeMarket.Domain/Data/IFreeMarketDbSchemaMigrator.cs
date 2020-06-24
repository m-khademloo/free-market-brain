using System.Threading.Tasks;

namespace FreeMarket.Data
{
    public interface IFreeMarketDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
