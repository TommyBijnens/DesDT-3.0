namespace test_accessories___selectionh
{
    partial class Cover
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.provisionBox = new System.Windows.Forms.TextBox();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cableEntryBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AssemblyDrawingBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.supportingPlateBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.airVentCountBox = new System.Windows.Forms.TextBox();
            this.airVentBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.insulatorLProfileBox = new System.Windows.Forms.TextBox();
            this.insulatorBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.connectionBarCountBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.connectionBarBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.accessPlateBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.paintingBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.glantPlateBox = new System.Windows.Forms.TextBox();
            this.busductBox = new System.Windows.Forms.TextBox();
            this.cabinBox = new System.Windows.Forms.TextBox();
            this.finishingBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxCableboxes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.DisplayMember = "Description";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(371, 355);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deleteItems);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.provisionBox);
            this.groupBox1.Controls.Add(this.distanceBox);
            this.groupBox1.Controls.Add(this.CodeBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(395, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 374);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accessory details";
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.provisionBox_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Accessory code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Distance to tank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Provision on cover";
            // 
            // provisionBox
            // 
            this.provisionBox.AllowDrop = true;
            this.provisionBox.Location = new System.Drawing.Point(124, 296);
            this.provisionBox.Name = "provisionBox";
            this.provisionBox.ReadOnly = true;
            this.provisionBox.Size = new System.Drawing.Size(200, 20);
            this.provisionBox.TabIndex = 6;
            this.provisionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.provisionBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.provisionBox_DragDrop);
            this.provisionBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // distanceBox
            // 
            this.distanceBox.Location = new System.Drawing.Point(124, 322);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(200, 20);
            this.distanceBox.TabIndex = 5;
            this.distanceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.distanceBox.TextChanged += new System.EventHandler(this.distanceBox_TextChanged);
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(124, 348);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.ReadOnly = true;
            this.CodeBox.Size = new System.Drawing.Size(200, 20);
            this.CodeBox.TabIndex = 2;
            this.CodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 376);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accessory selection";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 419);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accessories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cableboxes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Location = new System.Drawing.Point(6, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(383, 200);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Picture";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cableEntryBox);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.AssemblyDrawingBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.supportingPlateBox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.airVentCountBox);
            this.groupBox4.Controls.Add(this.airVentBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.insulatorLProfileBox);
            this.groupBox4.Controls.Add(this.insulatorBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.connectionBarCountBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.connectionBarBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.accessPlateBox);
            this.groupBox4.Controls.Add(this.colorBox);
            this.groupBox4.Controls.Add(this.paintingBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.glantPlateBox);
            this.groupBox4.Controls.Add(this.busductBox);
            this.groupBox4.Controls.Add(this.cabinBox);
            this.groupBox4.Controls.Add(this.finishingBox);
            this.groupBox4.Location = new System.Drawing.Point(395, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 374);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cablebox details";
            this.groupBox4.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox4_DragDrop);
            this.groupBox4.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "# Cable entries";
            // 
            // cableEntryBox
            // 
            this.cableEntryBox.AllowDrop = true;
            this.cableEntryBox.Location = new System.Drawing.Point(124, 348);
            this.cableEntryBox.Name = "cableEntryBox";
            this.cableEntryBox.Size = new System.Drawing.Size(200, 20);
            this.cableEntryBox.TabIndex = 37;
            this.cableEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Assembly drawing";
            // 
            // AssemblyDrawingBox
            // 
            this.AssemblyDrawingBox.AllowDrop = true;
            this.AssemblyDrawingBox.Location = new System.Drawing.Point(124, 296);
            this.AssemblyDrawingBox.Name = "AssemblyDrawingBox";
            this.AssemblyDrawingBox.ReadOnly = true;
            this.AssemblyDrawingBox.Size = new System.Drawing.Size(200, 20);
            this.AssemblyDrawingBox.TabIndex = 35;
            this.AssemblyDrawingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AssemblyDrawingBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AssemblyDrawingBox_MouseDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Supporting plate";
            // 
            // supportingPlateBox
            // 
            this.supportingPlateBox.AllowDrop = true;
            this.supportingPlateBox.Location = new System.Drawing.Point(124, 123);
            this.supportingPlateBox.Name = "supportingPlateBox";
            this.supportingPlateBox.ReadOnly = true;
            this.supportingPlateBox.Size = new System.Drawing.Size(200, 20);
            this.supportingPlateBox.TabIndex = 33;
            this.supportingPlateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.supportingPlateBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisplayDrawing);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Air vent";
            // 
            // airVentCountBox
            // 
            this.airVentCountBox.AllowDrop = true;
            this.airVentCountBox.Location = new System.Drawing.Point(124, 253);
            this.airVentCountBox.Name = "airVentCountBox";
            this.airVentCountBox.ReadOnly = true;
            this.airVentCountBox.Size = new System.Drawing.Size(34, 20);
            this.airVentCountBox.TabIndex = 31;
            this.airVentCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // airVentBox
            // 
            this.airVentBox.AllowDrop = true;
            this.airVentBox.Location = new System.Drawing.Point(164, 253);
            this.airVentBox.Name = "airVentBox";
            this.airVentBox.ReadOnly = true;
            this.airVentBox.Size = new System.Drawing.Size(160, 20);
            this.airVentBox.TabIndex = 30;
            this.airVentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Insulator L profile";
            // 
            // insulatorLProfileBox
            // 
            this.insulatorLProfileBox.AllowDrop = true;
            this.insulatorLProfileBox.Location = new System.Drawing.Point(164, 216);
            this.insulatorLProfileBox.Name = "insulatorLProfileBox";
            this.insulatorLProfileBox.ReadOnly = true;
            this.insulatorLProfileBox.Size = new System.Drawing.Size(160, 20);
            this.insulatorLProfileBox.TabIndex = 26;
            this.insulatorLProfileBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // insulatorBox
            // 
            this.insulatorBox.AllowDrop = true;
            this.insulatorBox.Location = new System.Drawing.Point(164, 190);
            this.insulatorBox.Name = "insulatorBox";
            this.insulatorBox.ReadOnly = true;
            this.insulatorBox.Size = new System.Drawing.Size(160, 20);
            this.insulatorBox.TabIndex = 22;
            this.insulatorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Insulator";
            // 
            // connectionBarCountBox
            // 
            this.connectionBarCountBox.AllowDrop = true;
            this.connectionBarCountBox.Location = new System.Drawing.Point(124, 164);
            this.connectionBarCountBox.Name = "connectionBarCountBox";
            this.connectionBarCountBox.ReadOnly = true;
            this.connectionBarCountBox.Size = new System.Drawing.Size(34, 20);
            this.connectionBarCountBox.TabIndex = 20;
            this.connectionBarCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Connection bar";
            // 
            // connectionBarBox
            // 
            this.connectionBarBox.AllowDrop = true;
            this.connectionBarBox.Location = new System.Drawing.Point(164, 164);
            this.connectionBarBox.Name = "connectionBarBox";
            this.connectionBarBox.ReadOnly = true;
            this.connectionBarBox.Size = new System.Drawing.Size(160, 20);
            this.connectionBarBox.TabIndex = 18;
            this.connectionBarBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.connectionBarBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisplayDrawing);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Access plate";
            // 
            // accessPlateBox
            // 
            this.accessPlateBox.AllowDrop = true;
            this.accessPlateBox.Location = new System.Drawing.Point(124, 97);
            this.accessPlateBox.Name = "accessPlateBox";
            this.accessPlateBox.ReadOnly = true;
            this.accessPlateBox.Size = new System.Drawing.Size(200, 20);
            this.accessPlateBox.TabIndex = 16;
            this.accessPlateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(304, 322);
            this.colorBox.Name = "colorBox";
            this.colorBox.ReadOnly = true;
            this.colorBox.Size = new System.Drawing.Size(20, 20);
            this.colorBox.TabIndex = 15;
            this.colorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // paintingBox
            // 
            this.paintingBox.Location = new System.Drawing.Point(164, 322);
            this.paintingBox.Name = "paintingBox";
            this.paintingBox.ReadOnly = true;
            this.paintingBox.Size = new System.Drawing.Size(134, 20);
            this.paintingBox.TabIndex = 14;
            this.paintingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Glant plate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Painting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cabin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Busduct";
            // 
            // glantPlateBox
            // 
            this.glantPlateBox.AllowDrop = true;
            this.glantPlateBox.Location = new System.Drawing.Point(124, 71);
            this.glantPlateBox.Name = "glantPlateBox";
            this.glantPlateBox.ReadOnly = true;
            this.glantPlateBox.Size = new System.Drawing.Size(200, 20);
            this.glantPlateBox.TabIndex = 7;
            this.glantPlateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.glantPlateBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisplayDrawing);
            // 
            // busductBox
            // 
            this.busductBox.AllowDrop = true;
            this.busductBox.Location = new System.Drawing.Point(124, 19);
            this.busductBox.Name = "busductBox";
            this.busductBox.ReadOnly = true;
            this.busductBox.Size = new System.Drawing.Size(200, 20);
            this.busductBox.TabIndex = 6;
            this.busductBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.busductBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisplayDrawing);
            // 
            // cabinBox
            // 
            this.cabinBox.Location = new System.Drawing.Point(124, 45);
            this.cabinBox.Name = "cabinBox";
            this.cabinBox.ReadOnly = true;
            this.cabinBox.Size = new System.Drawing.Size(200, 20);
            this.cabinBox.TabIndex = 5;
            this.cabinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cabinBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cabinBox2_MouseDoubleClick);
            // 
            // finishingBox
            // 
            this.finishingBox.Location = new System.Drawing.Point(124, 322);
            this.finishingBox.Name = "finishingBox";
            this.finishingBox.ReadOnly = true;
            this.finishingBox.Size = new System.Drawing.Size(34, 20);
            this.finishingBox.TabIndex = 2;
            this.finishingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxCableboxes);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 168);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cablebox selection";
            // 
            // listBoxCableboxes
            // 
            this.listBoxCableboxes.AllowDrop = true;
            this.listBoxCableboxes.DisplayMember = "Description";
            this.listBoxCableboxes.FormattingEnabled = true;
            this.listBoxCableboxes.Location = new System.Drawing.Point(6, 19);
            this.listBoxCableboxes.Name = "listBoxCableboxes";
            this.listBoxCableboxes.Size = new System.Drawing.Size(371, 134);
            this.listBoxCableboxes.TabIndex = 1;
            this.listBoxCableboxes.SelectedIndexChanged += new System.EventHandler(this.listBoxCableboxes_SelectedIndexChanged);
            this.listBoxCableboxes.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxCableboxes_DragDrop);
            this.listBoxCableboxes.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            this.listBoxCableboxes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deleteItems);
            // 
            // Cover
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "Cover";
            this.Text = "Cover accessories WPF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cover_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.TextBox provisionBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox busductBox;
        private System.Windows.Forms.TextBox cabinBox;
        private System.Windows.Forms.TextBox finishingBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxCableboxes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox glantPlateBox;
        private System.Windows.Forms.TextBox paintingBox;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox accessPlateBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox insulatorBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox connectionBarCountBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox connectionBarBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox insulatorLProfileBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox airVentCountBox;
        private System.Windows.Forms.TextBox airVentBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox supportingPlateBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AssemblyDrawingBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cableEntryBox;
    }
}

