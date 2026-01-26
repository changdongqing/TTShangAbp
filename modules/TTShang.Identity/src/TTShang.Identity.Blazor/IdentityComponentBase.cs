using TTShang.Identity.Localization;
using Volo.Abp.AspNetCore.Components;

namespace TTShang.Identity.Blazor;

public abstract class IdentityComponentBase : AbpComponentBase
{
    protected IdentityComponentBase()
    {
        LocalizationResource = typeof(IdentityResource);
    }
}