using Volo.Abp.Modularity;

namespace TTShang.Identity;

[DependsOn(
    typeof(IdentityApplicationModule),
    typeof(IdentityDomainTestModule)
    )]
public class IdentityApplicationTestModule : AbpModule
{

}
