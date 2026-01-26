using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace TTShang.IdentityManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(IdentityManagementBlazorModule),
    typeof(IdentityManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class IdentityManagementBlazorWebAssemblyModule : AbpModule
{

}
