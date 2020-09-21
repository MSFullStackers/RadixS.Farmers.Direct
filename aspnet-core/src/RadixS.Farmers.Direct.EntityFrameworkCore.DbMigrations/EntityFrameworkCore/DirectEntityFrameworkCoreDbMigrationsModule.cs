using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace RadixS.Farmers.Direct.EntityFrameworkCore
{
    [DependsOn(
        typeof(DirectEntityFrameworkCoreModule)
        )]
    public class DirectEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DirectMigrationsDbContext>();
        }
    }
}
