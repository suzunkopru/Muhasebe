using Volo.Abp.Settings;

namespace Muhasebe.Settings;

public class MuhasebeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MuhasebeSettings.MySetting1));
    }
}
