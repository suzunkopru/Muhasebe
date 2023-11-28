using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Muhasebe.Data;
using Volo.Abp.DependencyInjection;

namespace Muhasebe.EntityFrameworkCore;

public class EntityFrameworkCoreMuhasebeDbSchemaMigrator
    : IMuhasebeDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMuhasebeDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the MuhasebeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MuhasebeDbContext>()
            .Database
            .MigrateAsync();
    }
}
