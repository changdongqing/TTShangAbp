using Volo.Abp.Modularity;

namespace TTShang.Identity;

[DependsOn(
    typeof(IdentityDomainModule),
    typeof(IdentityTestBaseModule)
)]
public class IdentityDomainTestModule : AbpModule
{

}
