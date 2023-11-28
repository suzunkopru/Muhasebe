using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Muhasebe.Blazor;

[Dependency(ReplaceServices = true)]
public class MuhasebeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Muhasebe";
}
