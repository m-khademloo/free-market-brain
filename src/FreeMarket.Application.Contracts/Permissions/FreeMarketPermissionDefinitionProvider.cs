using FreeMarket.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FreeMarket.Permissions
{
    public class FreeMarketPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FreeMarketPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FreeMarketPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FreeMarketResource>(name);
        }
    }
}
