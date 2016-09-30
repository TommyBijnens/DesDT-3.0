using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_accessories___selectionh
{
    public static class RAL_Colors
    {
        public static string name;
        static Dictionary<string, color> RAL_List = JsonConvert.DeserializeObject<Dictionary<string, color>>(File.ReadAllText(@"C:\Users\tommy.bijnens\Desktop\Accessories\RAL.json"));
        public class color
        {
            public string code;
            public string description;
        }


        public static string getDescription(string _name)
        {
           
            return RAL_List[_name].description;

        }

        public static System.Drawing.Color getColor(string _name)
        {
            
            ColorConverter convertor = new ColorConverter();
            Color result = (Color)convertor.ConvertFromString(RAL_List[_name].code);
            return result;

        }

    }
}
