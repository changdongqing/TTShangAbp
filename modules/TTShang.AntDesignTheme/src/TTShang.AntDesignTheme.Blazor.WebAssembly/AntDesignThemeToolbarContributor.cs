using System.Threading.Tasks;
using TTShang.AntDesignTheme.Blazor.Toolbars;
using TTShang.AntDesignTheme.Blazor.WebAssembly.Themes.AntDesignTheme;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace TTShang.AntDesignTheme.Blazor.WebAssembly;

public class AntDesignThemeToolbarContributor: IToolbarContributor
{
    public Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name == StandardToolbars.Main)
        {
            //TODO: Can we find a different way to understand if authentication was configured or not?
            var authenticationStateProvider = context.ServiceProvider
                .GetService<AuthenticationStateProvider>();

            if (authenticationStateProvider != null)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginDisplay)));
            }
        }

        return Task.CompletedTask;
    }
}
