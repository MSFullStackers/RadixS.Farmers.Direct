using RadixS.Farmers.Direct.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RadixS.Farmers.Direct.Permissions
{
    public class DirectPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DirectPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(DirectPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DirectResource>(name);
        }
    }
}
