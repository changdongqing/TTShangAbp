using Microsoft.Extensions.DependencyInjection;
//using TTShang.AntDesignTheme.Blazor.Menus;
using TTShang.AntDesignUI;
using Volo.Abp.AspNetCore.Components.Web.Security;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.Mapperly;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace TTShang.AntDesignTheme.Blazor;

[DependsOn(
    typeof(AntDesignThemeApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpMapperlyModule),
    typeof(AbpAntDesignUIModule),
    typeof(AbpUiNavigationModule)
    )]
public class AntDesignThemeBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDynamicLayoutComponentOptions>(options =>
        {
            options.Components.Add(typeof(AbpAuthenticationState), null);
        });
    }
}
