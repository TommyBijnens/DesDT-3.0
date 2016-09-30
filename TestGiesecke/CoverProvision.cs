using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace test_accessories___selectionh
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CoverProvisionStruct
    {
        [MarshalAs(UnmanagedType.U4)]
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


    class ImportCoverProvision
    {
        public int id { get; set; }
        public string description { get; set; }
        public string code { get; set; }
    }

    public class CoverProvision
    {
        public int id { get; set; } = 123;
        public string description { get; set; } = "provision description";
        public string code { get; set; } = "ZBxxxxxx";
        public CoverProvision()
        { }

        public CoverProvision(string inputName)
        {
            ImportCoverProvision input = JsonConvert.DeserializeObject<ImportCoverProvision>(File.ReadAllText(inputName));
            this.id = input.id;
            this.description = input.description;
            this.code = input.code;
        }

        public CoverProvisionStruct toStruct()
        {
            CoverProvisionStruct result = new CoverProvisionStruct(id, code, description);
            return (result);
        }
    }
}
