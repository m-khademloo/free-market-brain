using Volo.Abp.Settings;

namespace FreeMarket.Settings
{
    public class FreeMarketSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FreeMarketSettings.MySetting1));
        }
    }
}
