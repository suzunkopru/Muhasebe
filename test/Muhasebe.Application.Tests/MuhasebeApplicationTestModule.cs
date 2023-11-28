using Volo.Abp.Modularity;

namespace Muhasebe;

[DependsOn(
    typeof(MuhasebeApplicationModule),
    typeof(MuhasebeDomainTestModule)
    )]
public class MuhasebeApplicationTestModule : AbpModule
{

}
