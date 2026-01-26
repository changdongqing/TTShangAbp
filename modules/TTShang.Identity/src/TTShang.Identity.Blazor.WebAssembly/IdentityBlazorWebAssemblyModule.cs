using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace TTShang.Identity.Blazor.WebAssembly;

[DependsOn(
    typeof(IdentityBlazorModule),
    typeof(IdentityHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class IdentityBlazorWebAssemblyModule : AbpModule
{

}
