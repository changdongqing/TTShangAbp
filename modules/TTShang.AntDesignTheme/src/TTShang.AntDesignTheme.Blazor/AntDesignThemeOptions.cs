using AntDesign;
using System;
using System.Collections.Generic;
using System.Text;
using TTShang.AntDesignTheme.Blazor.Settings;

namespace TTShang.AntDesignTheme.Blazor
{
    public class AntDesignThemeOptions
    {
        public MenuOptions Menu { get; set; }

        /// <summary>
        /// Enable multiple tabs in the application.
        /// </summary>
        public bool EnableMultipleTabs { get; set; }

        public AntDesignThemeOptions()
        {
            Menu = new MenuOptions();
        }
    }
    public class MenuOptions
    {
        public MenuTheme Theme { get; set; }

        public MenuPlacement Placement { get; set; }

        public MenuOptions()
        {
            Theme = MenuTheme.Dark;
            Placement = MenuPlacement.Left;
        }
    }
}
