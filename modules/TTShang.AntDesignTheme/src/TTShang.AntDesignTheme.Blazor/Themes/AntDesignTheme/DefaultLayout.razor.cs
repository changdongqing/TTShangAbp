using System;
using System.Threading.Tasks;
using AntDesign;
using AntDesign.ProLayout;
using TTShang.AntDesignTheme.Blazor.Settings;
using Microsoft.AspNetCore.Components;
using Volo.Abp.UI.Navigation;

namespace TTShang.AntDesignTheme.Blazor.Themes.AntDesignTheme;

public partial class DefaultLayout : IDisposable
{
    [Inject]
    protected IAntDesignSettingsProvider AntDesignSettingsProvider { get; set; }

    [Inject]
    protected IMenuManager MenuManager { get; set; }

    protected bool Collapsed { get; set; }

    protected MenuDataItem[] MenuData { get; set; } = [];

    protected override async Task OnInitializedAsync()
    {
        await LoadMenuDataAsync();
        AntDesignSettingsProvider.SettingChanged += OnSettingChanged;
    }

    protected virtual async Task OnSettingChanged()
    {
        await InvokeAsync(StateHasChanged);
    }

    private async Task LoadMenuDataAsync()
    {
        var menu = await MenuManager.GetMainMenuAsync();
        MenuData = MenuDataHelper.ConvertToMenuDataItems(menu);
    }

    protected virtual void OnCollapse()
    {
        Collapsed = !Collapsed;
    }

    public void Dispose()
    {
        AntDesignSettingsProvider.SettingChanged -= OnSettingChanged;
    }
}
