using TTShang.AntDesignTheme.Blazor.Server.Bundling;
using TTShang.AntDesignTheme.Blazor.Toolbars;
using Volo.Abp.AspNetCore.Components.Server;
using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.AspNetCore.Components.Server.Theming.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Packages;
using Volo.Abp.Modularity;

namespace TTShang.AntDesignTheme.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerModule),
    typeof(AbpAspNetCoreMvcUiPackagesModule),
    typeof(AbpAspNetCoreMvcUiBundlingModule),
    typeof(AntDesignThemeBlazorModule)
    )]
public class AntDesignThemeBlazorServerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .Add(Bundling.BlazorStandardBundles.Styles.Global, bundle =>
                {
                    bundle.AddContributors(typeof(Bundling.BlazorGlobalStyleContributor));
                });

            options
                .ScriptBundles
                .Add(Bundling.BlazorStandardBundles.Scripts.Global, bundle =>
                {
                    bundle.AddContributors(typeof(Bundling.BlazorGlobalScriptContributor));
                });

            options
                .StyleBundles
                .Add(BlazorAntDesignThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(Bundling.BlazorStandardBundles.Styles.Global)
                        .AddContributors(typeof(BlazorAntDesignThemeStyleContributor));
                });

            options
                .ScriptBundles
                .Add(BlazorAntDesignThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(Bundling.BlazorStandardBundles.Scripts.Global)
                        .AddContributors(typeof(BlazorAntDesignThemeScriptContributor));
                });
        });

        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new AntDesignThemeToolbarContributor());
        });
    }
}
