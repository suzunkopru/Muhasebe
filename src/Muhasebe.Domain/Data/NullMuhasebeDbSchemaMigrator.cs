using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Muhasebe.Data;

/* This is used if database provider does't define
 * IMuhasebeDbSchemaMigrator implementation.
 */
public class NullMuhasebeDbSchemaMigrator : IMuhasebeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
