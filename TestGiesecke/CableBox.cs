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
    public struct CableBoxStruc
    {
        [MarshalAs(UnmanagedType.U4)]
        public UInt32 id;
     //   public unsafe int* testArray;
        public unsafe IntPtr code;
        public unsafe IntPtr description;
        public unsafe IntPtr provision;


        public unsafe CableBoxStruc(int _id, string _code, string _description, CableBoxProvision _provision)
        {
            this.id = Convert.ToUInt32(_id);
        //    fixed (int* pointer = _testArray) { this.testArray = pointer; };

            this.code = Marshal.StringToHGlobalAnsi(_code);
            this.description = Marshal.StringToHGlobalAnsi(_description);
            IntPtr pnt = Marshal.AllocHGlobal(Marshal.SizeOf(_provision.toStruct()));
            Marshal.StructureToPtr(_provision.toStruct(), pnt, false);
            this.provision = pnt;
        }
    }


   

    public class CableBox
    {
        public int id { get; set; } = 456;
        public string description { get; set; } = "...";
        public string code { get; set; } = "ZBxxxxxx";
        public string picture { get; set; }
        public CableBoxProvision cableBoxProvision { get; set; } = new CableBoxProvision();
        public CableBoxCabin cableBoxCabin { get; set; } = new CableBoxCabin();
        public bool cabinEnabled = true;
        public CableBoxItem glantPlate { get; set; } = new CableBoxItem();
        public CableBoxItem accessPlate { get; set; } = new CableBoxItem();
        public bool accessPlateEnabled = true;
        public CableBoxItem connectionBar { get; set; } = new CableBoxItem();
        public int connectionBarCount = 0;
        public bool connectionBarEnabled = true;
        public CableBoxItem insulator { get; set; } = new CableBoxItem();
        public bool insulatorEnabled = true;
        public CableBoxItem airVent { get; set; } = new CableBoxItem();
        public int airVentCount = 0;
        public CableBoxItem supportingPlate { get; set; } = new CableBoxItem();
        public bool supportingPlateEnabled = true;
        public CableBoxItem insulatorLProfile { get; set; } = new CableBoxItem();
        public bool insulatorLProfileEnabled = true;
        public CableBoxColor color = new CableBoxColor();
        public CableBoxFinish finish = new CableBoxFinish();
        
        public string drawing = "";

        public CableBox()
        {}

        public CableBox(string inputName)
        {
           CableBox input = JsonConvert.DeserializeObject<CableBox>(File.ReadAllText(inputName));
            this.id = input.id;
            this.description = input.description;
            this.code = input.code;
            this.picture = input.picture;
            this.cabinEnabled = input.cabinEnabled;
            this.accessPlateEnabled = input.accessPlateEnabled;
            this.connectionBarCount = input.connectionBarCount;
            this.insulatorLProfileEnabled = input.insulatorLProfileEnabled;
            this.airVentCount = input.airVentCount;
            this.insulatorEnabled = input.insulatorEnabled;
            this.supportingPlateEnabled = input.supportingPlateEnabled;
            this.connectionBarEnabled = input.connectionBarEnabled;
        }


        public CableBoxStruc toStruct()
        {

             CableBoxStruc result = new CableBoxStruc(id, code, description, cableBoxProvision);
             return (result);
        
        }


    }

}

