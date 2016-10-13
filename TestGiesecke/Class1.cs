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
using TestGiesecke.ServiceReference1;
using WpfApplication2;

class Test
{
    static BasicHttpBinding binding = new BasicHttpBinding();
    static TestGiesecke.ServiceReference1.Service1Client trafo;
   // static Cover cover = trafo.


       [DllExport("getAccessoryList", CallingConvention = CallingConvention.Cdecl)]
       public unsafe static CoverAccessoryStruc* getAccessoryList()
       {
      //  MessageBox.Show("1");
        //List<CoverAccessory> coverAccessoryList = trafo.GetCover().accessoryList;
 
            CoverAccessory[] coverAccessories = trafo.GetCover().accessoryList;//trafo.GetCover().accessoryList;//new CoverAccessory[coverAccessoryList.Count()];
       
      //   MessageBox.Show("2");
        CoverAccessoryStruc[] coverAccessoriesStruc = new CoverAccessoryStruc[coverAccessories.Count()];
           int i = 0;
           foreach (CoverAccessory a in coverAccessories)
           {
               coverAccessories[i] = a;
               coverAccessoriesStruc[i] = Structurize.From(coverAccessories[i]);
               i++;
           }
      //  MessageBox.Show("3");
      
        fixed (CoverAccessoryStruc* pointer = coverAccessoriesStruc) {return pointer; };
       
    }
       
    
       [DllExport("AccessoryCount", CallingConvention = CallingConvention.Cdecl)]
       public static int AccessoryCount()
       {
           return trafo.GetCover().accessoryList.Count();
       }

    /*
       [DllExport("display", CallingConvention = CallingConvention.Cdecl)]
       public static void display()
       {
           Thread _STAThread = new Thread(new ThreadStart(test));
           _STAThread.SetApartmentState(ApartmentState.STA);
           _STAThread.Start();
       }

   */
    [DllExport("setDesign", CallingConvention = CallingConvention.Cdecl)]
    public static void setDesign(string value)
    {

        binding.Name = "CreoWebServiceDefPortBinding";
        EndpointAddress endpoint = new EndpointAddress("http://localhost:59392/TransformerService.svc?wdsl");
        trafo = new TestGiesecke.ServiceReference1.Service1Client(binding, endpoint);
        trafo.SetWorkNumber(value);
        //MessageBox.Show("trafo created "+trafo.GetWorkNumber());
    }


    [DllExport("getData", CallingConvention = CallingConvention.Cdecl)]
    public static void getData(int value)
    {
        CoverAccessory ca = trafo.GetData(value);
        //string output = trafo.GetData(value);
        MessageBox.Show(ca.description + " " + ca.code);
    }


    [DllExport("getAccessory", CallingConvention = CallingConvention.Cdecl)]
    public unsafe static CoverAccessoryStruc getAccessory()
    {
      /*  CoverAccessory accessory = new CoverAccessory();
        accessory.id = 393;
        accessory.testArray = new int[3] { 10, 20, 30 };
        accessory.code = "ZBxxxxxx";*/
        CoverAccessory ca = trafo.GetData(0);
        return Structurize.From(ca);//accessory.toStruct();
    }




    [DllExport("testWS", CallingConvention = CallingConvention.Cdecl)]
    public unsafe static void testWS()
    {
      
       
        //   trafo.set
        string output = trafo.GetParameterList(); //Creo.getParameters();
                                                  //  output = output.Substring(0, 6);

        MessageBox.Show(output);

    }




}



