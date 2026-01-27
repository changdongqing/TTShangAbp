using TTShang.AntDesignTheme.Blazor;
using TTShang.AntDesignTheme.Blazor.Routing;
using TTShang.AntDesignTheme.Blazor.Toolbars;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Components.Web;
using Volo.Abp.AspNetCore.Components.WebAssembly;
using Volo.Abp.Http.Client.IdentityModel.WebAssembly;
using Volo.Abp.Modularity;

namespace TTShang.AntDesignTheme.Blazor.WebAssembly;

[DependsOn(
    typeof(AbpAspNetCoreComponentsWebAntDesignThemeModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyModule),
    typeof(AbpHttpClientIdentityModelWebAssemblyModule)
)]
public class AbpAspNetCoreComponentsWebAssemblyAntDesignThemeModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(AbpAspNetCoreComponentsWebAssemblyAntDesignThemeModule).Assembly);
        });

        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new AntDesignThemeToolbarContributor());
        });
        
        if (context.Services.ExecutePreConfiguredActions<AbpAspNetCoreComponentsWebOptions>().IsBlazorWebApp)
        {
            Configure<AuthenticationOptions>(options =>
            {
                options.LoginUrl = "Account/Login";
                options.LogoutUrl = "Account/Logout";
            });
        }
    }
}
