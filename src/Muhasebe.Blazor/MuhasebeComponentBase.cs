using Muhasebe.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Muhasebe.Blazor;

public abstract class MuhasebeComponentBase : AbpComponentBase
{
    protected MuhasebeComponentBase()
    {
        LocalizationResource = typeof(MuhasebeResource);
    }
}
