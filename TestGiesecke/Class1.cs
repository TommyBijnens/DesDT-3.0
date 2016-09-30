using Newtonsoft.Json;
using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_accessories___selectionh;
using TestGiesecke;




class Test
{
    static Cover cover = new Cover();

    // [MarshalAs(UnmanagedType.LPStruct)]
    //    public static Provision provision;

    [DllExport("getAccessory", CallingConvention = CallingConvention.Cdecl)]
 //   [return: MarshalAs(UnmanagedType.LPStruct)]
    public unsafe static CoverAccessoryStruc getAccessory()
    {

        CoverAccessory accessory = new CoverAccessory();
        accessory.id = 393;
        accessory.testArray = new int[3] { 10, 20, 30};
        accessory.code = "ZBxxxxxx";

        return accessory.toStruct();
    }

    [DllExport("getAccessoryList", CallingConvention = CallingConvention.Cdecl)]
    public unsafe static CoverAccessoryStruc* getAccessoryList()
    {
        List <CoverAccessory> coverAccessoryList = cover.getList();

        CoverAccessory[] coverAccessories = new CoverAccessory[coverAccessoryList.Count()];
        CoverAccessoryStruc[] coverAccessoriesStruc = new CoverAccessoryStruc[coverAccessoryList.Count()];
        
                int i = 0;
                foreach (CoverAccessory a in coverAccessoryList)
                  {
                  //  coverAccessories[i] = new CoverAccessory();
                    coverAccessories[i] = a;
                //  coverAccessories[i].coverProvision.id = 222;
                    coverAccessoriesStruc[i] = coverAccessories[i].toStruct();
                    i++;
                }
                
    

        fixed (CoverAccessoryStruc* pointer = coverAccessoriesStruc) {return pointer; };
    }
    


    [DllExport("AccessoryCount", CallingConvention = CallingConvention.Cdecl)]
    public static int AccessoryCount()

    {
        return cover.getList().Count();
    }

    [DllExport("getTestArray", CallingConvention = CallingConvention.Cdecl)]
    public unsafe static int* getTestArray()

    {
          int[] test = new int[3];
           test[2] = 999;
           fixed (int* pointer = test) { return pointer;};
       

    }
  
    [DllExport("display", CallingConvention = CallingConvention.Cdecl)]
    public static void display()
    {
        Thread _STAThread = new Thread(new ThreadStart(test));
        _STAThread.SetApartmentState(ApartmentState.STA);
        _STAThread.Start();
       

    }

    public static void test()
    {
        
        cover.ShowDialog();
    }


    /*  [DllExport("getTestArray", CallingConvention = CallingConvention.Cdecl)]
      public unsafe static Provision[] getProvisionList()

      {
          Provision p1 = new Provision();
          Provision p2 = new Provision();
          Provision p3 = new Provision();
          p1.name = "test1";
          p1.code = "code1";
          p2.name = "test2";
          p2.code = "code2";
          p3.name = "test3";
          p3.code = "code3";
          p1.testArray[0] = 123;
          p1.testArray[1] = 123;
          p1.testArray[2] = 123;
          p2.testArray[0] = 123;
          p2.testArray[1] = 123;
          p2.testArray[2] = 123;
          p3.testArray[0] = 123;
          p3.testArray[1] = 123;
          p3.testArray[2] = 123;

          Provision[] export = new Provision[3];
          export[0] = p1;
          export[1] = p2;
          export[3] = p3;


          fixed (int* pointer = export) { return pointer; };


      }*/




}



