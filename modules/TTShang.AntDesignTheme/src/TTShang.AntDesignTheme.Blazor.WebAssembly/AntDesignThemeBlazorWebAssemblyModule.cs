using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace TTShang.AntDesignTheme.Blazor.WebAssembly;

[DependsOn(
    typeof(AntDesignThemeBlazorModule),
    typeof(AntDesignThemeHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class AntDesignThemeBlazorWebAssemblyModule : AbpModule
{

}
