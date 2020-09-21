using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RadixS.Farmers.Direct.Data;
using Volo.Abp.DependencyInjection;

namespace RadixS.Farmers.Direct.EntityFrameworkCore
{
    public class EntityFrameworkCoreDirectDbSchemaMigrator
        : IDirectDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDirectDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DirectMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DirectMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}