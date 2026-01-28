using System.Collections.Generic;
using System.Linq;
using AntDesign.ProLayout;
using Volo.Abp.UI.Navigation;

namespace TTShang.AntDesignTheme.Blazor.Themes.AntDesignTheme;

public static class MenuDataHelper
{
    public static MenuDataItem[] ConvertToMenuDataItems(ApplicationMenu menu)
    {
        if (menu?.Items == null)
        {
            return [];
        }

        return menu.Items.Select(ConvertMenuItem).ToArray();
    }

    private static MenuDataItem ConvertMenuItem(ApplicationMenuItem menuItem)
    {
        var item = new MenuDataItem
        {
            Path = menuItem.Url?.TrimStart('/', '~') ?? "#",
            Name = menuItem.DisplayName,
            Key = menuItem.ElementId ?? "MenuItem_" + menuItem.Name.Replace(".", "_"),
            Icon = menuItem.Icon,
            HideInMenu = menuItem.IsDisabled
        };

        if (menuItem.Items != null && menuItem.Items.Any())
        {
            item.Children = menuItem.Items.Select(ConvertMenuItem).ToArray();
        }

        return item;
    }
}
