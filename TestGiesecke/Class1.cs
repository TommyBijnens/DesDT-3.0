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


    [DllExport("getAccessory", CallingConvention = CallingConvention.Cdecl)]
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
            coverAccessories[i] = a;
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

  
    [DllExport("display", CallingConvention = CallingConvention.Cdecl)]
    public static void display()
    {
        Thread _STAThread = new Thread(new ThreadStart(test));
        _STAThread.SetApartmentState(ApartmentState.STA);
        _STAThread.Start();
    }


    [DllExport("setDesign", CallingConvention = CallingConvention.Cdecl)]
    public static void setDesign(string value)
    {
       cover.setDesign(value);
       cover.load();
    }


    [DllExport("testSend", CallingConvention = CallingConvention.Cdecl)]
    public unsafe static void testSend(CoverAccessoryStruc* input)
    {
        //  CoverProvision cp = (new CoverProvision(input));
        //  MessageBox.Show("helloObject " + cp.id + " " + cp.code + " " + cp.description);
        CoverAccessory ca = (new CoverAccessory(input));
        MessageBox.Show("helloObject " + ca.id + " " + ca.testArray[2] + " " + ca.description + " " + ca.coverProvision.description + " " +ca.distanceToEdge )  ;
    }



    public static void test()
    {
        
        cover.ShowDialog();
    }


   

}



