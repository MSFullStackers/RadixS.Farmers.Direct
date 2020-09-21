using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RadixS.Farmers.Direct.Data
{
    /* This is used if database provider does't define
     * IDirectDbSchemaMigrator implementation.
     */
    public class NullDirectDbSchemaMigrator : IDirectDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}