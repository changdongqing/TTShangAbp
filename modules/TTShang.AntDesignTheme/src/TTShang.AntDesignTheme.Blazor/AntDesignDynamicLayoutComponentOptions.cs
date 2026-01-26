using System;
using System.Collections.Generic;
using System.Text;

namespace TTShang.AntDesignTheme.Blazor
{
    public class AntDesignDynamicLayoutComponentOptions
    {
        /// <summary>
        /// Used to define components that renders in the layout
        /// </summary>
        public Dictionary<Type, IDictionary<string, object>?> Components { get; set; }

        public AntDesignDynamicLayoutComponentOptions()
        {
            Components = new Dictionary<Type, IDictionary<string, object>?>();
        }
    }
}
