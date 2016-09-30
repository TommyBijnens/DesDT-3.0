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
    public struct CableBoxProvisionStruct
    {
        [MarshalAs(UnmanagedType.U4)]
        public UInt32 id;
        public unsafe IntPtr code;
        public unsafe IntPtr description;

        public CableBoxProvisionStruct(int _id, string _code, string _description)
        {
            this.id = Convert.ToUInt32(_id);
            this.code = Marshal.StringToHGlobalAnsi(_code);
            this.description = Marshal.StringToHGlobalAnsi(_description);
        }
    }

 
   


    public class CableBoxItem
    {
        public int id { get; set; } = 123;
        public string description { get; set; } = "";
        public string code { get; set; } = "";
        public string type = "";
        public string drawing = "";
        public string provisionFile = "";
        public string cabinFile = "";
        public string glantPlateFile = "";
        public string supportingPlateFile = "";
        public string connectionBarFile = "";
        public string InsulatorFile = "";
        public string insulatorLProfileFile = "";
        public string airVentFile = "";



        public CableBoxItem()
        { }

        public CableBoxItem(string inputName)
        {
            try
            {
                CableBoxItem input = JsonConvert.DeserializeObject<CableBoxItem>(File.ReadAllText(inputName));
                this.id = input.id;
                this.description = input.description;
                this.code = input.code;
                this.type = input.type;
                this.drawing = input.drawing;
                this.provisionFile = input.provisionFile;
                this.cabinFile = input.cabinFile;
                this.glantPlateFile = input.glantPlateFile;
                this.supportingPlateFile = input.supportingPlateFile;
                this.connectionBarFile = input.connectionBarFile;
                this.InsulatorFile = input.InsulatorFile;
                this.insulatorLProfileFile = input.insulatorLProfileFile;
                this.airVentFile = input.airVentFile;
            }
            catch (Exception ex) { }//file not found?

        }

        public CoverProvisionStruct toStruct()
        {
            CoverProvisionStruct result = new CoverProvisionStruct(id, code, description);
            return (result);
        }
    }


    public class CableBoxProvision : CableBoxItem{
        public CableBoxProvision() : base() { }
        public CableBoxProvision(String input) : base(input){}
    }


    public class CableBoxCabin : CableBoxItem
    {
        public CableBoxCabin() : base() { }
        public CableBoxCabin(String input) : base(input){ }
    }

    public class CableboxAssembly : CableBoxItem
    {
        public CableboxAssembly() : base() { }
        public CableboxAssembly(String input) : base(input)
        {

        }
    }



    public class CableBoxColor : CableBoxItem
    {
        public CableBoxColor() : base() { }
        public CableBoxColor(String input) : base(input) { }
    }
    
    public class CableBoxFinish : CableBoxItem
    {
        public CableBoxFinish() : base() { }
        public CableBoxFinish(String input) : base(input) { }
    }

   

}
