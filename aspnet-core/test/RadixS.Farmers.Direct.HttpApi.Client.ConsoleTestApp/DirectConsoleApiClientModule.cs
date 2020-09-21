using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace RadixS.Farmers.Direct.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(DirectHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DirectConsoleApiClientModule : AbpModule
    {
        
    }
}
