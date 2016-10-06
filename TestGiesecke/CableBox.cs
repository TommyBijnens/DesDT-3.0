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
    public struct CableBoxStruc
    {
        [MarshalAs(UnmanagedType.U4)]
        public UInt32 id;
     //   public unsafe int* testArray;
        public unsafe IntPtr code;
        public unsafe IntPtr description;
        public unsafe IntPtr provision;


        public unsafe CableBoxStruc(int _id, string _code, string _description, CableBoxItem _provision)
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

    class ImportCableBox
    {
        public int id { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public string picture { get; set; }
        public string defaultProvision { get; set; }
        public string defaultCabin { get; set; }
        public string defaultGlantPlate { get; set; }
        public string defaultAccessPlate { get; set; }
        public string defaultConnectionBar { get; set; }
        public string defaultInsulator { get; set; }
        public string defaultAirVent { get; set; }
        public string defaultSupportingPlate { get; set; }
        public string defaultInsulatorLProfile { get; set; }
        public int connectionBarCount { get; set; }
        public int airVentCount { get; set; }
        public int cableEntryCount { get; set; }
    }


    public class CableBox
    {
        public int id { get; set; } = 456;
        public string description { get; set; } = "...";
        public string code { get; set; } = "ZBxxxxxx";
        public string picture { get; set; }
        public CableBoxItem cableBoxProvision { get; set; } = new CableBoxItem();
        public CableBoxItem cableBoxCabin { get; set; } = new CableBoxItem();
        public CableBoxItem glantPlate { get; set; } = new CableBoxItem();
        public CableBoxItem accessPlate { get; set; } = new CableBoxItem();
        public CableBoxItem connectionBar { get; set; } = new CableBoxItem();
       
        public CableBoxItem insulator { get; set; } = new CableBoxItem();
        public CableBoxItem airVent { get; set; } = new CableBoxItem();
        public CableBoxItem supportingPlate { get; set; } = new CableBoxItem();
        public CableBoxItem insulatorLProfile { get; set; } = new CableBoxItem();

        public int connectionBarCount = 0;
        public int airVentCount = 0;
        public int cableEntryCount = 0;

        public CableBoxItem color = new CableBoxItem();
        public CableBoxItem finish = new CableBoxItem();
        
        public string drawing = "";

        public CableBox()
        {}

        public CableBox(string inputName)
        {
            ImportCableBox input = JsonConvert.DeserializeObject<ImportCableBox>(File.ReadAllText(inputName));
            this.id = input.id;
            this.description = input.description;
            this.code = input.code;
            this.picture = input.picture;
            cableBoxProvision = new CableBoxItem(input.defaultProvision);
            cableBoxCabin = new CableBoxItem(input.defaultCabin);
            glantPlate = new CableBoxItem(input.defaultGlantPlate);
            accessPlate = new CableBoxItem(input.defaultAccessPlate);
            connectionBar = new CableBoxItem(input.defaultConnectionBar);
            insulator = new CableBoxItem(input.defaultInsulator);
            airVent = new CableBoxItem(input.defaultAirVent);
            supportingPlate = new CableBoxItem(input.defaultSupportingPlate);
            insulatorLProfile = new CableBoxItem(input.defaultInsulatorLProfile);


            this.connectionBarCount = input.connectionBarCount;
            this.airVentCount = input.airVentCount;
            this.cableEntryCount = input.cableEntryCount;

        }


        public CableBoxStruc toStruct()
        {

             CableBoxStruc result = new CableBoxStruc(id, code, description, cableBoxProvision);
             return (result);
        
        }


    }

}

