using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace TTShang.Identity.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(IdentityBlazorModule)
    )]
public class IdentityBlazorServerModule : AbpModule
{

}
