using Muhasebe.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Muhasebe;

[DependsOn(
    typeof(MuhasebeEntityFrameworkCoreTestModule)
    )]
public class MuhasebeDomainTestModule : AbpModule
{

}
