using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestGiesecke;
using WpfApplication2;
using System.Collections.ObjectModel;
using test_accessories___selectionh;

namespace TestGiesecke
{

    public partial class CoverClass
    {
        public Color defaultColor;
        public Color defaultBackground;
        public string designNumber;
        public ObservableCollection<CoverAccessory> accessoryList = new ObservableCollection<CoverAccessory>();
        public ObservableCollection<CableBox> cableboxList = new ObservableCollection<CableBox>();
        public CoverClass()
        {
            CoverAccessory a1 = new CoverAccessory();
            accessoryList.Add(a1);
            designNumber = "";

        }

        public void setDesign(string input)
        {
            designNumber = input;
            //Text = "Cover accessories - " + input;
        }


        public void load()
        {
            List<CoverAccessory> loadedList = new List<CoverAccessory>();
            loadedList = JsonConvert.DeserializeObject<List<CoverAccessory>>(File.ReadAllText(Design.getDirectory(designNumber) + "coverAccessories.json"));
            accessoryList = new ObservableCollection<CoverAccessory>(loadedList);
  
            List<CableBox> loadedList2 = new List<CableBox>();
            loadedList2 = JsonConvert.DeserializeObject<List<CableBox>>(File.ReadAllText(Design.getDirectory(designNumber) + "cableBoxes.json"));
            cableboxList = new ObservableCollection<CableBox>(loadedList2);
       }


 
  /*      public void checkProvision()
        {
            try
            {
                CoverAccessory selectedAccessory = (CoverAccessory)listBox2.SelectedItem;
                if (selectedAccessory.isAcceptedProvision(selectedAccessory.coverProvision.code)) provisionBox.BackColor = defaultColor;
                else provisionBox.BackColor = Color.Red;
            }
            catch (Exception ex) { };
        }*/


        public void save()
        {
            File.WriteAllText(Design.getDirectory(designNumber) + "coverAccessories.json", JsonConvert.SerializeObject(accessoryList));
            File.WriteAllText(Design.getDirectory(designNumber) + "cableBoxes.json", JsonConvert.SerializeObject(cableboxList));
        }


        
   /*     public void clear()
        {
            listBox2.Items.Clear();
            listBoxCableboxes.Items.Clear();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            provisionBox.Text = "";
            distanceBox.Text = "";
            CodeBox.Text = "";
            listBox2.Items.Clear();
            provisionBox.BackColor = defaultColor;
            listBoxCableboxes.Items.Clear();
            busductBox.Text = "";
            cabinBox.Text = "";
            cabinBox.Text = "";
            accessPlateBox.Text = "";
            supportingPlateBox.Text = "";
            connectionBarBox.Text = "";
            connectionBarCountBox.Text = "";
            insulatorBox.Text = "";
            insulatorLProfileBox.Text = "";
            airVentBox.Text = "";
            airVentCountBox.Text = "";
            AssemblyDrawingBox.Text = "";
            finishingBox.Text = "";
            colorBox.Text = "";
            colorBox.BackColor = defaultBackground;
            cableEntryBox.Text = "";
        }


        


       



        private void groupBox4_DragDrop(object sender, DragEventArgs e)
        {


        }


        private void cabinBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CableBox selectedCableBox = (CableBox)listBoxCableboxes.SelectedItem;
            System.Diagnostics.Process.Start(selectedCableBox.cableBoxCabin.drawing);
        }


        public void Bind(Control control, CableBoxItem cableboxItem)
        {
            control.DataBindings.Clear();
            control.DataBindings.Add("Text", cableboxItem, "description");
            control.DataBindings.Add("Visible", cableboxItem, "enabled");
        }


        public void displayDetails(CableBox selectedCablebox)
        {

            Bind(busductBox, selectedCablebox.cableBoxProvision);
            Bind(cabinBox, selectedCablebox.cableBoxCabin);

            try
            {
                paintingBox.Text = selectedCablebox.color.description + " (" + RAL_Colors.getDescription(selectedCablebox.color.description) + ")";
                colorBox.BackColor = RAL_Colors.getColor(selectedCablebox.color.description);
            }
            catch (Exception ex) { paintingBox.Text = ""; colorBox.BackColor = defaultBackground; }

            finishingBox.Text = selectedCablebox.finish.description;

            Bind(glantPlateBox, selectedCablebox.glantPlate);
            Bind(accessPlateBox, selectedCablebox.accessPlate);
            Bind(supportingPlateBox, selectedCablebox.supportingPlate);

            Bind(insulatorLProfileBox, selectedCablebox.insulatorLProfile);

            Bind(insulatorBox, selectedCablebox.insulator);
            Bind(connectionBarBox, selectedCablebox.connectionBar);

            Bind(airVentBox, selectedCablebox.airVent);

            airVentCountBox.Text = selectedCablebox.airVentCount.ToString();
            connectionBarCountBox.Text = selectedCablebox.connectionBarCount.ToString();
            cableEntryBox.Text = selectedCablebox.cableEntryCount.ToString();
            AssemblyDrawingBox.Text = selectedCablebox.code;
        }



        private void AssemblyDrawingBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CableBox selectedCableBox = (CableBox)listBoxCableboxes.SelectedItem;
            System.Diagnostics.Process.Start(selectedCableBox.drawing);
        }



  


        private void DisplayDrawing(object sender, MouseEventArgs e)
        {
            Binding db = ((TextBox)sender).DataBindings["text"];
            CableBoxItem boundItem = (CableBoxItem)db.DataSource;
            System.Diagnostics.Process.Start(boundItem.drawing);
        }

 */
    }
}
