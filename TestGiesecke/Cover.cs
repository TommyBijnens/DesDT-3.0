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

namespace test_accessories___selectionh
{
    
    public partial class Cover : Form
    {
        public Color defaultColor;
        public Color defaultBackground;
        public Cover()
        {
            InitializeComponent();
            groupBox1.AllowDrop = true;
            groupBox4.AllowDrop = true;
            defaultColor = provisionBox.BackColor;
            defaultBackground = colorBox.BackColor;
            load();

        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
            {
                string input = s[i];
                //CoverAccessory coverAccessory = new CoverAccessory(input);
                //listBox2.Items.Add(coverAccessory);
               
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(s[i]);

                CoverAccessory coverAccessory = new CoverAccessory(link.TargetPath);
                listBox2.Items.Add(coverAccessory);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void distanceBox_TextChanged(object sender, EventArgs e)
        {
            CoverAccessory selectedAccessory = (CoverAccessory)listBox2.SelectedItem;
            selectedAccessory.distanceToEdge = Convert.ToInt32(distanceBox.Text);
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
            File.WriteAllText(@"C:\temp\coverAccessories.json", JsonConvert.SerializeObject(listBox2.Items));
            File.WriteAllText(@"C:\temp\cableBoxes.json", JsonConvert.SerializeObject(listBoxCableboxes.Items));
        }

        public void load()
        {
            List<CoverAccessory> loadedList = new List<CoverAccessory>();
            loadedList = JsonConvert.DeserializeObject<List<CoverAccessory>>(File.ReadAllText(@"C:\temp\coverAccessories.json"));
            listBox2.Items.Clear();
            listBox2.Items.AddRange(loadedList.ToArray());

            List<CableBox> loadedList2 = new List<CableBox>();
            loadedList2 = JsonConvert.DeserializeObject<List<CableBox>>(File.ReadAllText(@"C:\temp\cableBoxes.json"));
            listBoxCableboxes.Items.Clear();
            listBoxCableboxes.Items.AddRange(loadedList2.ToArray());
            


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



        private void button2_Click_1(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            save();
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
                if (cableBoxItem.type == "cablebox provision") { selectedCablebox.cableBoxProvision = new CableBoxProvision(link.TargetPath); }
                if (cableBoxItem.type == "cablebox cabin") { selectedCablebox.cableBoxCabin = new CableBoxCabin(link.TargetPath);}
                if (cableBoxItem.type == "cablebox glantPlate") { selectedCablebox.glantPlate = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox supportingPlate") { selectedCablebox.supportingPlate = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox connectionBar") { selectedCablebox.connectionBar = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox insulator") { selectedCablebox.insulator = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox insulatorLProfile") { selectedCablebox.insulatorLProfile = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox airVent") { selectedCablebox.airVent = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox assembly")
                {
                    selectedCablebox.cableBoxProvision = new CableBoxProvision(cableBoxItem.provisionFile);
                    selectedCablebox.cableBoxCabin = new CableBoxCabin(cableBoxItem.cabinFile);

                    selectedCablebox.glantPlate = new CableBoxItem(cableBoxItem.glantPlateFile);
                    selectedCablebox.supportingPlate = new CableBoxItem(cableBoxItem.supportingPlateFile);
                    selectedCablebox.connectionBar = new CableBoxItem(cableBoxItem.connectionBarFile);
                    selectedCablebox.insulator = new CableBoxItem(cableBoxItem.InsulatorFile);
                    selectedCablebox.insulatorLProfile = new CableBoxItem(cableBoxItem.insulatorLProfileFile);
                    selectedCablebox.airVent = new CableBoxItem(cableBoxItem.airVentFile);

                    selectedCablebox.code = cableBoxItem.code;
                    selectedCablebox.drawing = cableBoxItem.drawing;
                }

                else if (cableBoxItem.type == "color") { selectedCablebox.color = new CableBoxColor(link.TargetPath); }
                else if (cableBoxItem.type == "finish") { selectedCablebox.finish = new CableBoxFinish(link.TargetPath); }
                else selectedCablebox.code = "";

            }
            displayDetails(selectedCablebox);
            
        }

        private void provisionBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CableBox selectedCableBox = (CableBox)listBoxCableboxes.SelectedItem;
            System.Diagnostics.Process.Start(selectedCableBox.cableBoxProvision.drawing);
        }

        private void cabinBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CableBox selectedCableBox = (CableBox)listBoxCableboxes.SelectedItem;
            System.Diagnostics.Process.Start(selectedCableBox.cableBoxCabin.drawing);
        }

        public void displayDetails(CableBox selectedCablebox)
        {
            busductBox.Text = selectedCablebox.cableBoxProvision.description;
            if (selectedCablebox.cabinEnabled) { cabinBox.Visible = true; cabinBox.Text = selectedCablebox.cableBoxCabin.description; }
            else { cabinBox.Visible = false; }
            try
            {
                paintingBox.Text = selectedCablebox.color.description + " (" + RAL_Colors.getDescription(selectedCablebox.color.description) + ")";
                colorBox.BackColor = RAL_Colors.getColor(selectedCablebox.color.description);
            }
            catch (Exception ex) { paintingBox.Text = ""; colorBox.BackColor = defaultBackground; }
            finishingBox.Text = selectedCablebox.finish.description;

            glantPlateBox.Text = selectedCablebox.glantPlate.description;
            accessPlateBox.Text = selectedCablebox.accessPlate.description;
            supportingPlateBox.Text = selectedCablebox.supportingPlate.description;

            insulatorBox.Text = selectedCablebox.insulator.description;
            connectionBarBox.Text = selectedCablebox.connectionBar.description;
            connectionBarCountBox.Text = selectedCablebox.connectionBarCount.ToString();

            airVentBox.Text = selectedCablebox.airVent.description;
            airVentCountBox.Text = selectedCablebox.airVentCount.ToString();

            if (selectedCablebox.accessPlateEnabled) { accessPlateBox.Visible = true; accessPlateBox.Text = selectedCablebox.accessPlate.description; }
            else { accessPlateBox.Visible = false; }

            if (selectedCablebox.insulatorLProfileEnabled) { insulatorLProfileBox.Visible = true; insulatorLProfileBox.Text = selectedCablebox.insulatorLProfile.description; }
            else { insulatorLProfileBox.Visible = false; }

            if (selectedCablebox.insulatorEnabled) { insulatorBox.Visible = true; insulatorBox.Text = selectedCablebox.insulator.description; }
            else { insulatorBox.Visible = false; }

            if (selectedCablebox.supportingPlateEnabled) { supportingPlateBox.Visible = true; supportingPlateBox.Text = selectedCablebox.supportingPlate.description; }
            else { supportingPlateBox.Visible = false; }

            if (selectedCablebox.connectionBarEnabled) { connectionBarBox.Visible = true; connectionBarBox.Text = selectedCablebox.connectionBar.description; connectionBarCountBox.Visible = true; connectionBarCountBox.Text = selectedCablebox.connectionBarCount.ToString(); }
            else { connectionBarBox.Visible = false; connectionBarCountBox.Visible = false; }

            AssemblyDrawingBox.Text = selectedCablebox.code;
            

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void AssemblyDrawingBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CableBox selectedCableBox = (CableBox)listBoxCableboxes.SelectedItem;
            System.Diagnostics.Process.Start(selectedCableBox.drawing);
        }






        private void supportingPlateBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CableBox selectedCableBox = (CableBox)listBoxCableboxes.SelectedItem;
            System.Diagnostics.Process.Start(selectedCableBox.supportingPlate.drawing);
        }

        private void glantPlateBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CableBox selectedCableBox = (CableBox)listBoxCableboxes.SelectedItem;
            System.Diagnostics.Process.Start(selectedCableBox.glantPlate.drawing);
        }

        private void connectionBarBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CableBox selectedCableBox = (CableBox)listBoxCableboxes.SelectedItem;
            System.Diagnostics.Process.Start(selectedCableBox.connectionBar.drawing);
        }
    }
}
