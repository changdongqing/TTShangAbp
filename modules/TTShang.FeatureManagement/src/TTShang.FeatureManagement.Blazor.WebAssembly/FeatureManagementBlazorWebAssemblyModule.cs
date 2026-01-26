using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace TTShang.FeatureManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(FeatureManagementBlazorModule),
    typeof(FeatureManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class FeatureManagementBlazorWebAssemblyModule : AbpModule
{

}
