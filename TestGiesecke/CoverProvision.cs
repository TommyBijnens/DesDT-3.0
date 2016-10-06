using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_accessories___selectionh
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CoverProvisionStruct
    {
        public UInt32 id;
        public unsafe IntPtr code;
        public unsafe IntPtr description;

        public CoverProvisionStruct(int _id, string _code, string _description)
        {
            this.id = Convert.ToUInt32(_id);
            this.code = Marshal.StringToHGlobalAnsi(_code);
            this.description = Marshal.StringToHGlobalAnsi(_description);
        }
    }


    public class CoverProvision
    {
        public int id { get; set; } = 123;
        public string description { get; set; } = "provision description";
        public string code { get; set; } = "ZBxxxxxx";

        public CoverProvision()
        {}

        public CoverProvision(string inputName)
        {
            CoverProvision input = JsonConvert.DeserializeObject<CoverProvision>(File.ReadAllText(inputName));
            this.id = input.id;
            this.description = input.description;
            this.code = input.code;
        }

        public unsafe CoverProvision (CoverProvisionStruct * inputPtr)
        {
            CoverProvisionStruct input = new CoverProvisionStruct();
            IntPtr pnt = (IntPtr)inputPtr;
            try { input = (CoverProvisionStruct)Marshal.PtrToStructure(pnt, typeof(CoverProvisionStruct)); }
            catch (Exception ex) { MessageBox.Show("hello " + ex.ToString()); }
            id = Convert.ToInt32(input.id);
            description = Marshal.PtrToStringAnsi(input.description);
            code = Marshal.PtrToStringAnsi(input.code);
        }


        public CoverProvisionStruct toStruct()
        {
            CoverProvisionStruct result = new CoverProvisionStruct(id, code, description);
            return (result);
        }
    }
}
