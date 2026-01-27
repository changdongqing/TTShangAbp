using TTShang.AntDesignTheme.Blazor.WebAssembly;
using TTShang.PermissionManagement.Blazor;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace TTShang.PermissionManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(AbpPermissionManagementBlazorAntDesignModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyAntDesignThemeModule),
    typeof(AbpPermissionManagementHttpApiClientModule)
)]
public class AbpPermissionManagementBlazorWebAssemblyAntDesignModule : AbpModule
{
}
