using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGiesecke
{
    static class Design
    {
        public static  string getDirectory(string design)
        {
            string result = "V:\\DT_SD_Product";
            result += "\\" + design.Substring(0, 4);
            result += "\\" + design.Substring(0, 5);
            result += "\\" + design.Substring(0, 6);
            result += "\\" + design.Substring(0, 7);
            result += "\\" + design.Substring(0, 7)+"_ELEC\\";
            return result;
        }
    }
}
