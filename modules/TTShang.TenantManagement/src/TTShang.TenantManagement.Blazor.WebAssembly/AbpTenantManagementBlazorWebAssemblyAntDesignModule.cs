using TTShang.FeatureManagement.Blazor.WebAssembly;
using TTShang.TenantManagement.Blazor;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace TTShang.TenantManagement.Blazor.WebAssembly;


[DependsOn(
    typeof(AbpTenantManagementBlazorAntDesignModule),
    typeof(AbpFeatureManagementBlazorWebAssemblyAntDesignModule),
    typeof(AbpTenantManagementHttpApiClientModule)
)]
public class AbpTenantManagementBlazorWebAssemblyAntDesignModule : AbpModule
{
    
}
