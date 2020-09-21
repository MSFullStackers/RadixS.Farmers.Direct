using Volo.Abp.Modularity;

namespace RadixS.Farmers.Direct
{
    [DependsOn(
        typeof(DirectApplicationModule),
        typeof(DirectDomainTestModule)
        )]
    public class DirectApplicationTestModule : AbpModule
    {

    }
}