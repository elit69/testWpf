using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace testWpf.Helper
{
    class Debug
    {
        public void debugJson(Object object) {

            string json = JsonConvert.SerializeObject(object);
        }
    }
}
