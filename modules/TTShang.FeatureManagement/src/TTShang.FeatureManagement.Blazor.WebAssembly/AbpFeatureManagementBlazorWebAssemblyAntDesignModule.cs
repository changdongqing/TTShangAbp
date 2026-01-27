using TTShang.AntDesignTheme.Blazor.WebAssembly;
using TTShang.FeatureManagement.Blazor;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;

namespace TTShang.FeatureManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(AbpFeatureManagementBlazorAntDesignModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyAntDesignThemeModule),
    typeof(AbpFeatureManagementHttpApiClientModule)
)]
public class AbpFeatureManagementBlazorWebAssemblyAntDesignModule : AbpModule
{
}
