using Muhasebe.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Muhasebe.Permissions;

public class MuhasebePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MuhasebePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MuhasebePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MuhasebeResource>(name);
    }
}
