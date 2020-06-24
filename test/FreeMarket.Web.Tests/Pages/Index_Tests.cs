using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace FreeMarket.Pages
{
    public class Index_Tests : FreeMarketWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
