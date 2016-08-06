using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Windows;

namespace testWpf.Helper
{
    class Debug
    {
        public static void debugJson(Object object1)
        {
            MessageBox.Show(JsonConvert.SerializeObject(object1, Formatting.Indented));
        }

        public static String debugJsonStr(Object object1)
        {
            return JsonConvert.SerializeObject(object1, Formatting.Indented);
        }
    }
}
