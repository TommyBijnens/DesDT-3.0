using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using test_accessories___selectionh;
using TestGiesecke;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CoverClass cover;
        public MainWindow(CoverClass _cover)
        {
            InitializeComponent();
            cover = _cover;
            listBox1.ItemsSource = cover.accessoryList;
            listBox2.ItemsSource = cover.cableboxList;
        }

        private void DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effects = DragDropEffects.All;
            else
                e.Effects = DragDropEffects.None;
        
         }

        private void listBox1_Drop(object sender, DragEventArgs e)
        {
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                for (int i = 0; i < s.Length; i++)
                {
                    string input = s[i];
                    IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                    IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(s[i]);
                    CoverAccessory coverAccessory = new CoverAccessory(link.TargetPath);
                    cover.accessoryList.Add(coverAccessory);
                    //  listBox2.SelectedIndex = listBox2.Items.Count - 1;
                }
              //  checkProvision();
            }
        }

        private void DeleteKeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.Key == Key.Delete)
            {
                ListBox activeBox = (ListBox)sender;
                if (activeBox.SelectedItem != null)
                if (activeBox.Name == "listBox1") cover.accessoryList.Remove(activeBox.SelectedItem as CoverAccessory);
                if (activeBox.Name == "listBox2") cover.cableboxList.Remove(activeBox.SelectedItem as CableBox);

            }
        }

        private void CoverProvisionDrop(object sender, DragEventArgs e)
        {


            CoverAccessory selectedAccessory = (CoverAccessory)listBox1.SelectedItem;
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string input = s[0];
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(input);

            CoverProvision coverProvision = new CoverProvision(link.TargetPath);
            selectedAccessory.coverProvision = coverProvision;
            // checkProvision();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cover.save();
        }

        private void CableboxDrop(object sender, DragEventArgs e)
        {


            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
            {
                string input = s[i];
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(input);
                CableBox cableBox = new CableBox(link.TargetPath);
                cover.cableboxList.Add(cableBox);
            }

        }

        private void CableboxItemDrop(object sender, DragEventArgs e)
        {
            CableBox selectedCablebox = (CableBox)listBox2.SelectedItem;
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string input in s)
            {
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(input);
                CableBoxItem cableBoxItem = new CableBoxItem(link.TargetPath);
                if (cableBoxItem.type == "cablebox provision") { selectedCablebox.cableBoxProvision = new CableBoxItem(link.TargetPath); }
                if (cableBoxItem.type == "cablebox cabin") { selectedCablebox.cableBoxCabin = new CableBoxItem(link.TargetPath); }
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
            
        }
    }
}
