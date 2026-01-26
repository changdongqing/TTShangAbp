using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace TTShang.PermissionManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(PermissionManagementBlazorModule),
    typeof(PermissionManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class PermissionManagementBlazorWebAssemblyModule : AbpModule
{

}
