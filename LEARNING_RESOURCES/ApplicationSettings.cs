using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_RESOURCES
{
    internal static class ApplicationSettings
    {
       static ApplicationSettings()
        {
        }

        public enum Languages 
        {
            English=1,
            Farsi=2,
        }

        public static Languages CurrentCulture { get; set; }
    }
}
