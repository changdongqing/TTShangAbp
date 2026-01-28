using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace TTShang.AntDesignTheme.Blazor.Server.Bundling;

public class BlazorGlobalStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("_content/AntDesign.ProLayout/css/ant-design-pro-layout-blazor.css");
    }
}
