using TTShang.Identity.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TTShang.Identity;

public abstract class IdentityController : AbpControllerBase
{
    protected IdentityController()
    {
        LocalizationResource = typeof(IdentityResource);
    }
}
