using RadixS.Farmers.Direct.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RadixS.Farmers.Direct.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DirectEntityFrameworkCoreDbMigrationsModule),
        typeof(DirectApplicationContractsModule)
        )]
    public class DirectDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
