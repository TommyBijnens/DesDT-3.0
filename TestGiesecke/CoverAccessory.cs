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
    public struct CoverAccessoryStruc
    {
        public UInt32 id;
        public unsafe int* testArray;
        public unsafe IntPtr code;
        public unsafe IntPtr description;
        public unsafe IntPtr provision;
        public UInt32 distanceToEdge;

        public unsafe CoverAccessoryStruc(int _id, int[] _testArray, string _code, string _description, CoverProvision _provision, int _distanceToEdge)
        {
            this.id = Convert.ToUInt32(_id);
            fixed (int* pointer = _testArray) { this.testArray = pointer; };

            this.code = Marshal.StringToHGlobalAnsi(_code);
            this.description = Marshal.StringToHGlobalAnsi(_description);
            IntPtr pnt = Marshal.AllocHGlobal(Marshal.SizeOf(_provision.toStruct()));
            Marshal.StructureToPtr(_provision.toStruct(), pnt, false);
            this.provision = pnt;
            this.distanceToEdge = Convert.ToUInt32(_distanceToEdge);
        }
    }


    public class CoverAccessory
    {
        public int id { get; set; } = 456;
        public string description { get; set; } = "...";
        public string code { get; set; } = "ZBxxxxxx";
        public string picture { get; set; }
        public int distanceToEdge;
        public CoverProvision coverProvision { get; set; } = new CoverProvision();
        public string[] acceptedProvisionCodes { get; set; }
        public int[] testArray = new int[3] { 11, 22, 33 };
        public string defaultProvision { get; set; }


        public CoverAccessory()
        {}

        public CoverAccessory(string inputName)
        {
          CoverAccessory input = JsonConvert.DeserializeObject<CoverAccessory>(File.ReadAllText(inputName));
            this.id = input.id;
            this.description = input.description;
            this.code = input.code;
            this.picture = input.picture;
            this.distanceToEdge = input.distanceToEdge;
            coverProvision = new CoverProvision(input.defaultProvision);
            this.acceptedProvisionCodes = input.acceptedProvisionCodes;

        }


        public unsafe CoverAccessory(CoverAccessoryStruc* inputPtr)
        {
            CoverAccessoryStruc input = new CoverAccessoryStruc();
            IntPtr pnt = (IntPtr)inputPtr;
            input = (CoverAccessoryStruc)Marshal.PtrToStructure(pnt, typeof(CoverAccessoryStruc));

            id = Convert.ToInt32(input.id);

            IntPtr pnt2 = (IntPtr)input.testArray;
            int elementSize = Marshal.SizeOf(typeof(int));
            IntPtr j = pnt2;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    testArray[i] = Marshal.PtrToStructure<int>(j);
                    j = new IntPtr(j.ToInt64() + elementSize);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            code = Marshal.PtrToStringAnsi(input.code);
            description = Marshal.PtrToStringAnsi(input.description);
            coverProvision = new CoverProvision((CoverProvisionStruct*)input.provision);
            distanceToEdge = Convert.ToInt32(input.distanceToEdge);
        }



        public bool isAcceptedProvision(string input)
        {
            return acceptedProvisionCodes.Contains(input);
        }


        public CoverAccessoryStruc toStruct()
        {
            CoverAccessoryStruc result = new CoverAccessoryStruc(id, testArray, code, description, coverProvision, distanceToEdge);
            return (result);
        }


    }

}

