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

namespace test_accessories___selectionh
{
    
    public partial class Cover : Form
    {
        public Color defaultColor;
        public Color defaultBackground;
        public string designNumber;
        public Cover()
        {
            InitializeComponent();
            groupBox1.AllowDrop = true;
            groupBox4.AllowDrop = true;
            defaultColor = provisionBox.BackColor;
            defaultBackground = colorBox.BackColor;
            designNumber = "";
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
            {
                string input = s[i];
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(s[i]);
                CoverAccessory coverAccessory = new CoverAccessory(link.TargetPath);
                listBox2.Items.Add(coverAccessory);
                listBox2.SelectedIndex = listBox2.Items.Count-1;
            }
            checkProvision();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CoverAccessory selectedAccessory = (CoverAccessory)listBox2.SelectedItem;
                CodeBox.Text = selectedAccessory.code;



                Image preview = Image.FromFile(selectedAccessory.picture);
                pictureBox1.Image = preview;
                distanceBox.Text = selectedAccessory.distanceToEdge.ToString();
                provisionBox.Text = selectedAccessory.coverProvision.description.ToString();
            }
            catch (Exception ex) { CodeBox.Text = "";pictureBox1.Image = null; }
            checkProvision();

        }

        private void deleteItems(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ListBox activeBox = (ListBox)sender;
                activeBox.Items.Remove(activeBox.SelectedItem);
            }
        }


        private void distanceBox_TextChanged(object sender, EventArgs e)
        {
            CoverAccessory selectedAccessory = (CoverAccessory)listBox2.SelectedItem;
            if (distanceBox.Text != "") selectedAccessory.distanceToEdge = Convert.ToInt32(distanceBox.Text);
        }

        private void provisionBox_DragDrop(object sender, DragEventArgs e)
        {
            CoverAccessory selectedAccessory = (CoverAccessory)listBox2.SelectedItem;
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string input = s[0];
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(input);

            CoverProvision coverProvision = new CoverProvision(link.TargetPath);
            selectedAccessory.coverProvision = coverProvision;
            provisionBox.Text = coverProvision.description;
            checkProvision();
        }

        private void DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        public void checkProvision()
        {
            try
            {
                CoverAccessory selectedAccessory = (CoverAccessory)listBox2.SelectedItem;
                if (selectedAccessory.isAcceptedProvision(selectedAccessory.coverProvision.code)) provisionBox.BackColor = defaultColor;
                else provisionBox.BackColor = Color.Red;
            }
            catch (Exception ex) { };
        }


        public void save()
        {
            File.WriteAllText(Design.getDirectory(designNumber) + "coverAccessories.json", JsonConvert.SerializeObject(listBox2.Items));
            File.WriteAllText(Design.getDirectory(designNumber) + "cableBoxes.json", JsonConvert.SerializeObject(listBoxCableboxes.Items));
        }

        public void load()
        {
            clear();
            try
            {
                List<CoverAccessory> loadedList = new List<CoverAccessory>();
                loadedList = JsonConvert.DeserializeObject<List<CoverAccessory>>(File.ReadAllText(Design.getDirectory(designNumber) + "coverAccessories.json"));
                listBox2.Items.AddRange(loadedList.ToArray());

                List<CableBox> loadedList2 = new List<CableBox>();
                loadedList2 = JsonConvert.DeserializeObject<List<CableBox>>(File.ReadAllText(Design.getDirectory(designNumber) + "cableBoxes.json"));
                listBoxCableboxes.Items.AddRange(loadedList2.ToArray());
            }
            catch (Exception e)
            {
                clear();
                save();
            }
 
            try { if (listBox2.SelectedIndex == -1) listBox2.SelectedIndex = 0; } catch (Exception ex) { };
            try { if (listBoxCableboxes.SelectedIndex == -1) listBoxCableboxes.SelectedIndex = 0; } catch (Exception ex) { };
        }

        public void clear()
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
            cabinBox.Text= "";
            cabinBox.Text = "";
            accessPlateBox.Text = "";
            supportingPlateBox.Text = "";
            connectionBarBox.Text= "";
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


        public List<CoverAccessory> getList()
        {
            List<CoverAccessory> result = new List<CoverAccessory>();
            
            foreach (CoverAccessory a in listBox2.Items)
            {
                result.Add(a);
            }
            return result;
        }



      
        private void listBoxCableboxes_DragDrop(object sender, DragEventArgs e)
        {

            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
            {
                string input = s[i];
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(input);
                CableBox cableBox = new CableBox(link.TargetPath);
                listBoxCableboxes.Items.Add(cableBox);
                listBoxCableboxes.SelectedIndex = listBoxCableboxes.Items.Count-1;
            }
        }

        private void listBoxCableboxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CableBox selectedCablebox = (CableBox)listBoxCableboxes.SelectedItem;
                finishingBox.Text = selectedCablebox.code;
                Image preview = Image.FromFile(selectedCablebox.picture);
                pictureBox2.Image = preview;
                displayDetails(selectedCablebox);
            }
            catch (Exception ex) { finishingBox.Text = ""; pictureBox2.Image = null; }
        }



        private void groupBox4_DragDrop(object sender, DragEventArgs e)
        {
            CableBox selectedCablebox = (CableBox)listBoxCableboxes.SelectedItem;
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string input in s)
            {
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(input);
                CableBoxItem cableBoxItem = new CableBoxItem(link.TargetPath);
                if (cableBoxItem.type == "cablebox provision") { selectedCablebox.cableBoxProvision = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox cabin") { selectedCablebox.cableBoxCabin = new CableBoxItem(link.TargetPath);}
                if (cableBoxItem.type == "cablebox glantPlate") { selectedCablebox.glantPlate = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox supportingPlate") { selectedCablebox.supportingPlate = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox connectionBar") { selectedCablebox.connectionBar = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox insulator") { selectedCablebox.insulator = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox insulatorLProfile") { selectedCablebox.insulatorLProfile = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox airVent") { selectedCablebox.airVent = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox assembly")
                {
                    selectedCablebox.cableBoxProvision = new CableBoxItem(cableBoxItem.provisionFile);
                    selectedCablebox.cableBoxCabin = new CableBoxItem(cableBoxItem.cabinFile);

                    selectedCablebox.glantPlate = new CableBoxItem(cableBoxItem.glantPlateFile);
                    selectedCablebox.supportingPlate = new CableBoxItem(cableBoxItem.supportingPlateFile);
                    selectedCablebox.connectionBar = new CableBoxItem(cableBoxItem.connectionBarFile);
                    selectedCablebox.insulator = new CableBoxItem(cableBoxItem.InsulatorFile);
                    selectedCablebox.insulatorLProfile = new CableBoxItem(cableBoxItem.insulatorLProfileFile);
                    selectedCablebox.airVent = new CableBoxItem(cableBoxItem.airVentFile);

                    selectedCablebox.code = cableBoxItem.code;
                    selectedCablebox.drawing = cableBoxItem.drawing;
                }

                else if (cableBoxItem.type == "color") { selectedCablebox.color = new CableBoxItem(link.TargetPath); }
                else if (cableBoxItem.type == "finish") { selectedCablebox.finish = new CableBoxItem(link.TargetPath); }
                else selectedCablebox.code = "";

            }
            displayDetails(selectedCablebox);
            
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

    

        public void setDesign(string input)
        {
            designNumber = input;
            Text = "Cover accessories - " + input;
        }

        private void Cover_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
        }

        private void DisplayDrawing(object sender, MouseEventArgs e)
        {
            Binding db = ((TextBox)sender).DataBindings["text"];
            CableBoxItem boundItem = (CableBoxItem)db.DataSource;
            System.Diagnostics.Process.Start(boundItem.drawing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MainWindow mainWindow = new MainWindow();
           // mainWindow.ShowDialog();
        }
    }
}
