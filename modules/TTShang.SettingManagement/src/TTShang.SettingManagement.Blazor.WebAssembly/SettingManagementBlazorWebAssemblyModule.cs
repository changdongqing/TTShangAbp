using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace TTShang.SettingManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(SettingManagementBlazorModule),
    typeof(SettingManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class SettingManagementBlazorWebAssemblyModule : AbpModule
{

}
