using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormXml.configuration
{
    internal class AppConfiguration
    {
        public static string DatePath => Path.Combine(
        Directory.GetCurrentDirectory(),
        "DateForm.xml"
        );
    }
}
