using TTShang.IdentityManagement.Blazor;
using TTShang.PermissionManagement.Blazor.WebAssembly;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace TTShang.IdentityManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(AbpIdentityBlazorAntDesignModule),
    typeof(AbpPermissionManagementBlazorWebAssemblyAntDesignModule),
    typeof(AbpIdentityHttpApiClientModule)
)]
public class AbpIdentityBlazorWebAssemblyAntDesignModule: AbpModule
{
}
