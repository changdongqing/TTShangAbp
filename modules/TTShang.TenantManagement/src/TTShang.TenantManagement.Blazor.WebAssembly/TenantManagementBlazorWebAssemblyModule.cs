using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace TTShang.TenantManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(TenantManagementBlazorModule),
    typeof(TenantManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class TenantManagementBlazorWebAssemblyModule : AbpModule
{

}
