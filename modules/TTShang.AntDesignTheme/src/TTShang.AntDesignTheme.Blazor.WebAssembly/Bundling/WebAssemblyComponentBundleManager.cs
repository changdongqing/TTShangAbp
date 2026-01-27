using System.Collections.Generic;
using System.Threading.Tasks;
using TTShang.AntDesignTheme.Blazor.Bundling;
using Volo.Abp.DependencyInjection;

namespace TTShang.AntDesignTheme.Blazor.WebAssembly.Bundling;

public class WebAssemblyComponentBundleManager : IComponentBundleManager, ITransientDependency
{
    public virtual Task<IReadOnlyList<string>> GetStyleBundleFilesAsync(string bundleName)
    {
        return Task.FromResult<IReadOnlyList<string>>(new List<string>());
    }

    public virtual Task<IReadOnlyList<string>> GetScriptBundleFilesAsync(string bundleName)
    {
        return Task.FromResult<IReadOnlyList<string>>(new List<string>());
    }
}
