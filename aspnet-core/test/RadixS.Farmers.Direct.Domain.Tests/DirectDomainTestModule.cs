using RadixS.Farmers.Direct.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RadixS.Farmers.Direct
{
    [DependsOn(
        typeof(DirectEntityFrameworkCoreTestModule)
        )]
    public class DirectDomainTestModule : AbpModule
    {

    }
}