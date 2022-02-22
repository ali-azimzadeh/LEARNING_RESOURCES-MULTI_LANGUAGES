using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySettings
{
    public class Culture
    {
        public enum Language
        {
            English = 1,
            Farsi = 2,
        }

        public Language CurrentCulture { get; set; }
    }
}
