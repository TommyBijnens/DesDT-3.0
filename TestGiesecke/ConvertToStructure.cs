using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TestGiesecke.ServiceReference1;

namespace TestGiesecke
{
    public static class Structurize
    {
        public static CoverProvisionStruct From(CoverProvision input)
        {
            CoverProvisionStruct result = new CoverProvisionStruct(input.id, input.code, input.description);
            return (result);
        }

        public static CoverAccessoryStruc From(CoverAccessory input)
        {
            CoverAccessoryStruc result = new CoverAccessoryStruc(input.id, input.testArray, input.code, input.description, input.coverProvision, input.distanceToEdge);
            return (result);
        }

    }


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
            IntPtr pnt = Marshal.AllocHGlobal(Marshal.SizeOf(Structurize.From(_provision)));
            //IntPtr pnt = Marshal.AllocHGlobal(Marshal.SizeOf(_provision.toStruct()));
            Marshal.StructureToPtr(Structurize.From(_provision), pnt, false);
            this.provision = pnt;
            this.distanceToEdge = Convert.ToUInt32(_distanceToEdge);
        }
    }
}
