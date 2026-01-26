using TTShang.Identity.Localization;
using Volo.Abp.Application.Services;

namespace TTShang.Identity;

public abstract class IdentityAppService : ApplicationService
{
    protected IdentityAppService()
    {
        LocalizationResource = typeof(IdentityResource);
        ObjectMapperContext = typeof(IdentityApplicationModule);
    }
}
