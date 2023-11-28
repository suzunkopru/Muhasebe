using Muhasebe.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Muhasebe.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MuhasebeEntityFrameworkCoreModule),
    typeof(MuhasebeApplicationContractsModule)
    )]
public class MuhasebeDbMigratorModule : AbpModule
{
}
