using Newtonsoft.Json;
using QuanlySV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV
{
    public class Util
    {
        public static T ConvertToType<T>(object value)
        {
            var jsonData = JsonConvert.SerializeObject(value);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
        public static List<T> ConvertListToType<T>(object value)
        {
            var jsonData = JsonConvert.SerializeObject(value);
            return JsonConvert.DeserializeObject<List<T>>(jsonData);
        }
    }
}
