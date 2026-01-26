using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace TTShang.AntDesignTheme.Blazor.WebAssembly.Bundling;

[DependsOn(
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingBundlingModule)
)]
public class AntDesignThemeBlazorWebAssemblyBundlingModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBundlingOptions>(options =>
        {
            options.GlobalAssets.Enabled = true;
            options.GlobalAssets.GlobalStyleBundleName = BlazorWebAssemblyAntDesignThemeBundles.Styles.Global;
            options.GlobalAssets.GlobalScriptBundleName = BlazorWebAssemblyAntDesignThemeBundles.Scripts.Global;

            options
                .StyleBundles
                .Add(BlazorWebAssemblyStandardBundles.Styles.Global, bundle =>
                {
                    bundle.AddContributors(typeof(BlazorWebAssemblyStyleContributor));
                });

            options
                .ScriptBundles
                .Add(BlazorWebAssemblyStandardBundles.Scripts.Global, bundle =>
                {
                    bundle.AddContributors(typeof(BlazorWebAssemblyScriptContributor));
                });

            options
                .StyleBundles
                .Add(BlazorWebAssemblyAntDesignThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(BlazorWebAssemblyStandardBundles.Styles.Global)
                        .AddContributors(typeof(BlazorWebAssemblyAntDesignThemeStyleContributor));
                });

            options
                .ScriptBundles
                .Add(BlazorWebAssemblyAntDesignThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(BlazorWebAssemblyStandardBundles.Scripts.Global)
                        .AddContributors(typeof(BlazorWebAssemblyAntDesignThemeScriptContributor));
                });

            options.MinificationIgnoredFiles.Add("_content/Microsoft.AspNetCore.Components.WebAssembly.Authentication/AuthenticationService.js");
        });
    }
}