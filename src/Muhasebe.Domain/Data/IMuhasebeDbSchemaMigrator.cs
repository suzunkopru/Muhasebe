using System.Threading.Tasks;

namespace Muhasebe.Data;

public interface IMuhasebeDbSchemaMigrator
{
    Task MigrateAsync();
}
