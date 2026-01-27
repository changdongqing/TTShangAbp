using TTShang.AntDesignTheme.Blazor.WebAssembly;
using Volo.Abp.Modularity;
using TTShang.SettingManagement.Blazor;
using Volo.Abp.SettingManagement;

namespace TTShang.SettingManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(AbpSettingManagementBlazorAntDesignModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyAntDesignThemeModule),
    typeof(AbpSettingManagementHttpApiClientModule)
)]
public class AbpSettingManagementBlazorWebAssemblyAntDesignModule : AbpModule
{
    
}
