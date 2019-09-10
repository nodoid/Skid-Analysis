namespace skid_analysis
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ismph = new System.Windows.Forms.CheckBox();
            this.collisionspeed = new skid_analysis.NumberBox();
            this.label14 = new System.Windows.Forms.Label();
            this.brakergl = new System.Windows.Forms.RadioButton();
            this.brakelgr = new System.Windows.Forms.RadioButton();
            this.skidsbackfront = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.skidsequal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tyrecond = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tyretype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.longwheel = new System.Windows.Forms.CheckBox();
            this.vehicletype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.surfaceworn = new System.Windows.Forms.CheckBox();
            this.slopegrad = new skid_analysis.NumberBox();
            this.slopelbl = new System.Windows.Forms.Label();
            this.roadslope = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.distinm = new System.Windows.Forms.CheckBox();
            this.skidback = new skid_analysis.NumberBox();
            this.label9 = new System.Windows.Forms.Label();
            this.skidfront = new skid_analysis.NumberBox();
            this.label8 = new System.Windows.Forms.Label();
            this.daytime = new System.Windows.Forms.CheckBox();
            this.roadcover = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roadsurface = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.speedunit = new System.Windows.Forms.Label();
            this.minspeedbrake = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.distunit = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.equiv = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoryunit = new System.Windows.Forms.Label();
            this.theorystop = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ismph);
            this.groupBox1.Controls.Add(this.collisionspeed);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.brakergl);
            this.groupBox1.Controls.Add(this.brakelgr);
            this.groupBox1.Controls.Add(this.skidsbackfront);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.skidsequal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tyrecond);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tyretype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.longwheel);
            this.groupBox1.Controls.Add(this.vehicletype);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About the vehicle";
            // 
            // ismph
            // 
            this.ismph.AutoSize = true;
            this.ismph.Checked = true;
            this.ismph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ismph.Location = new System.Drawing.Point(304, 139);
            this.ismph.Name = "ismph";
            this.ismph.Size = new System.Drawing.Size(55, 17);
            this.ismph.TabIndex = 31;
            this.ismph.Text = "m.p.h.";
            this.ismph.UseVisualStyleBackColor = true;
            // 
            // collisionspeed
            // 
            this.collisionspeed.Location = new System.Drawing.Point(198, 137);
            this.collisionspeed.Name = "collisionspeed";
            this.collisionspeed.Size = new System.Drawing.Size(100, 20);
            this.collisionspeed.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Approx. collision speed (0 = unknown)";
            // 
            // brakergl
            // 
            this.brakergl.AutoSize = true;
            this.brakergl.Enabled = false;
            this.brakergl.Location = new System.Drawing.Point(278, 110);
            this.brakergl.Name = "brakergl";
            this.brakergl.Size = new System.Drawing.Size(141, 17);
            this.brakergl.TabIndex = 14;
            this.brakergl.Text = "Right longer than the left";
            this.brakergl.UseVisualStyleBackColor = true;
            // 
            // brakelgr
            // 
            this.brakelgr.AutoSize = true;
            this.brakelgr.Checked = true;
            this.brakelgr.Enabled = false;
            this.brakelgr.Location = new System.Drawing.Point(278, 79);
            this.brakelgr.Name = "brakelgr";
            this.brakelgr.Size = new System.Drawing.Size(140, 17);
            this.brakelgr.TabIndex = 13;
            this.brakelgr.TabStop = true;
            this.brakelgr.Text = "Left longer than the right";
            this.brakelgr.UseVisualStyleBackColor = true;
            // 
            // skidsbackfront
            // 
            this.skidsbackfront.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skidsbackfront.Enabled = false;
            this.skidsbackfront.FormattingEnabled = true;
            this.skidsbackfront.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.skidsbackfront.Location = new System.Drawing.Point(184, 109);
            this.skidsbackfront.Name = "skidsbackfront";
            this.skidsbackfront.Size = new System.Drawing.Size(61, 21);
            this.skidsbackfront.TabIndex = 12;
            this.skidsbackfront.SelectedIndexChanged += new System.EventHandler(this.skidsbackfront_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Are the back longer than the front?";
            // 
            // skidsequal
            // 
            this.skidsequal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skidsequal.FormattingEnabled = true;
            this.skidsequal.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.skidsequal.Location = new System.Drawing.Point(175, 78);
            this.skidsequal.Name = "skidsequal";
            this.skidsequal.Size = new System.Drawing.Size(61, 21);
            this.skidsequal.TabIndex = 9;
            this.skidsequal.SelectedIndexChanged += new System.EventHandler(this.skidsequal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Are the skid marks equal length?";
            // 
            // tyrecond
            // 
            this.tyrecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tyrecond.FormattingEnabled = true;
            this.tyrecond.Items.AddRange(new object[] {
            "7mm",
            "5mm",
            "3mm (legal min.)",
            "2mm",
            "1.6mm (bald)"});
            this.tyrecond.Location = new System.Drawing.Point(293, 47);
            this.tyrecond.Name = "tyrecond";
            this.tyrecond.Size = new System.Drawing.Size(121, 21);
            this.tyrecond.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tread depth";
            // 
            // tyretype
            // 
            this.tyretype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tyretype.FormattingEnabled = true;
            this.tyretype.Items.AddRange(new object[] {
            "Standard for vehicle",
            "Thinner than standard",
            "Wide"});
            this.tyretype.Location = new System.Drawing.Point(87, 47);
            this.tyretype.Name = "tyretype";
            this.tyretype.Size = new System.Drawing.Size(121, 21);
            this.tyretype.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tyre type";
            // 
            // longwheel
            // 
            this.longwheel.AutoSize = true;
            this.longwheel.Location = new System.Drawing.Point(225, 22);
            this.longwheel.Name = "longwheel";
            this.longwheel.Size = new System.Drawing.Size(107, 17);
            this.longwheel.TabIndex = 3;
            this.longwheel.Text = "Long wheel base";
            this.longwheel.UseVisualStyleBackColor = true;
            this.longwheel.CheckedChanged += new System.EventHandler(this.longwheel_CheckedChanged);
            // 
            // vehicletype
            // 
            this.vehicletype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicletype.FormattingEnabled = true;
            this.vehicletype.Items.AddRange(new object[] {
            "Motorcycle",
            "Small car",
            "Medium car",
            "Saloon car",
            "MPV",
            "Small van",
            "Van",
            "Lorry",
            "Bus"});
            this.vehicletype.Location = new System.Drawing.Point(87, 20);
            this.vehicletype.Name = "vehicletype";
            this.vehicletype.Size = new System.Drawing.Size(121, 21);
            this.vehicletype.TabIndex = 1;
            this.vehicletype.SelectedIndexChanged += new System.EventHandler(this.vehicletype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.surfaceworn);
            this.groupBox2.Controls.Add(this.slopegrad);
            this.groupBox2.Controls.Add(this.slopelbl);
            this.groupBox2.Controls.Add(this.roadslope);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.distinm);
            this.groupBox2.Controls.Add(this.skidback);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.skidfront);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.daytime);
            this.groupBox2.Controls.Add(this.roadcover);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.roadsurface);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Road and weather conditions";
            // 
            // surfaceworn
            // 
            this.surfaceworn.AutoSize = true;
            this.surfaceworn.Location = new System.Drawing.Point(322, 29);
            this.surfaceworn.Name = "surfaceworn";
            this.surfaceworn.Size = new System.Drawing.Size(95, 17);
            this.surfaceworn.TabIndex = 30;
            this.surfaceworn.Text = "Surface worn?";
            this.surfaceworn.UseVisualStyleBackColor = true;
            // 
            // slopegrad
            // 
            this.slopegrad.Enabled = false;
            this.slopegrad.Location = new System.Drawing.Point(339, 143);
            this.slopegrad.Name = "slopegrad";
            this.slopegrad.Size = new System.Drawing.Size(59, 20);
            this.slopegrad.TabIndex = 29;
            // 
            // slopelbl
            // 
            this.slopelbl.AutoSize = true;
            this.slopelbl.Enabled = false;
            this.slopelbl.Location = new System.Drawing.Point(240, 146);
            this.slopelbl.Name = "slopelbl";
            this.slopelbl.Size = new System.Drawing.Size(92, 13);
            this.slopelbl.TabIndex = 28;
            this.slopelbl.Text = "Slope gradient (%)";
            // 
            // roadslope
            // 
            this.roadslope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roadslope.FormattingEnabled = true;
            this.roadslope.Items.AddRange(new object[] {
            "On a flat road",
            "Travelling up hill",
            "Travelling down hill"});
            this.roadslope.Location = new System.Drawing.Point(95, 143);
            this.roadslope.Name = "roadslope";
            this.roadslope.Size = new System.Drawing.Size(121, 21);
            this.roadslope.TabIndex = 27;
            this.roadslope.SelectedIndexChanged += new System.EventHandler(this.roadslope_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "The vehicle was";
            // 
            // distinm
            // 
            this.distinm.AutoSize = true;
            this.distinm.Location = new System.Drawing.Point(243, 117);
            this.distinm.Name = "distinm";
            this.distinm.Size = new System.Drawing.Size(96, 17);
            this.distinm.TabIndex = 24;
            this.distinm.Text = "Distance in m?";
            this.distinm.UseVisualStyleBackColor = true;
            // 
            // skidback
            // 
            this.skidback.Enabled = false;
            this.skidback.Location = new System.Drawing.Point(161, 115);
            this.skidback.Name = "skidback";
            this.skidback.Size = new System.Drawing.Size(59, 20);
            this.skidback.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(6, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Measured skid distance (rear)";
            // 
            // skidfront
            // 
            this.skidfront.Location = new System.Drawing.Point(161, 88);
            this.skidfront.Name = "skidfront";
            this.skidfront.Size = new System.Drawing.Size(59, 20);
            this.skidfront.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Measured skid distance (front)";
            // 
            // daytime
            // 
            this.daytime.AutoSize = true;
            this.daytime.Location = new System.Drawing.Point(322, 59);
            this.daytime.Name = "daytime";
            this.daytime.Size = new System.Drawing.Size(64, 17);
            this.daytime.TabIndex = 18;
            this.daytime.Text = "Daytime";
            this.daytime.UseVisualStyleBackColor = true;
            // 
            // roadcover
            // 
            this.roadcover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roadcover.FormattingEnabled = true;
            this.roadcover.Items.AddRange(new object[] {
            "Dry",
            "Damp",
            "Wet",
            "Snow (loose)",
            "Snow (packed)",
            "Ice"});
            this.roadcover.Location = new System.Drawing.Point(87, 57);
            this.roadcover.Name = "roadcover";
            this.roadcover.Size = new System.Drawing.Size(217, 21);
            this.roadcover.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Road covering";
            // 
            // roadsurface
            // 
            this.roadsurface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roadsurface.FormattingEnabled = true;
            this.roadsurface.Items.AddRange(new object[] {
            "Concrete",
            "Asphalt",
            "Gravel"});
            this.roadsurface.Location = new System.Drawing.Point(87, 27);
            this.roadsurface.Name = "roadsurface";
            this.roadsurface.Size = new System.Drawing.Size(217, 21);
            this.roadsurface.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Road surface";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.theoryunit);
            this.groupBox3.Controls.Add(this.theorystop);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.speedunit);
            this.groupBox3.Controls.Add(this.minspeedbrake);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.distunit);
            this.groupBox3.Controls.Add(this.distance);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.equiv);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(13, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // speedunit
            // 
            this.speedunit.AutoSize = true;
            this.speedunit.Location = new System.Drawing.Point(247, 67);
            this.speedunit.Name = "speedunit";
            this.speedunit.Size = new System.Drawing.Size(36, 13);
            this.speedunit.TabIndex = 8;
            this.speedunit.Text = "m.p.h.";
            // 
            // minspeedbrake
            // 
            this.minspeedbrake.AutoSize = true;
            this.minspeedbrake.Location = new System.Drawing.Point(195, 67);
            this.minspeedbrake.Name = "minspeedbrake";
            this.minspeedbrake.Size = new System.Drawing.Size(13, 13);
            this.minspeedbrake.TabIndex = 7;
            this.minspeedbrake.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Minimum speed at start of breaking";
            // 
            // distunit
            // 
            this.distunit.AutoSize = true;
            this.distunit.Location = new System.Drawing.Point(247, 44);
            this.distunit.Name = "distunit";
            this.distunit.Size = new System.Drawing.Size(46, 13);
            this.distunit.TabIndex = 5;
            this.distunit.Text = "m away.";
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Location = new System.Drawing.Point(195, 44);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(13, 13);
            this.distance.TabIndex = 4;
            this.distance.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Shortest stop distance to avoid a skid";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "m.p.h.";
            // 
            // equiv
            // 
            this.equiv.AutoSize = true;
            this.equiv.Location = new System.Drawing.Point(223, 20);
            this.equiv.Name = "equiv";
            this.equiv.Size = new System.Drawing.Size(13, 13);
            this.equiv.TabIndex = 1;
            this.equiv.Text = "0";
            this.equiv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Energy equivalent speed scrubbed by skid";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(372, 422);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset data";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(372, 456);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printResultsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printResultsToolStripMenuItem
            // 
            this.printResultsToolStripMenuItem.Name = "printResultsToolStripMenuItem";
            this.printResultsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.printResultsToolStripMenuItem.Text = "Print results";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // theoryunit
            // 
            this.theoryunit.AutoSize = true;
            this.theoryunit.Location = new System.Drawing.Point(247, 89);
            this.theoryunit.Name = "theoryunit";
            this.theoryunit.Size = new System.Drawing.Size(46, 13);
            this.theoryunit.TabIndex = 11;
            this.theoryunit.Text = "m away.";
            // 
            // theorystop
            // 
            this.theorystop.AutoSize = true;
            this.theorystop.Location = new System.Drawing.Point(195, 89);
            this.theorystop.Name = "theorystop";
            this.theorystop.Size = new System.Drawing.Size(13, 13);
            this.theorystop.TabIndex = 10;
            this.theorystop.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Theoretical stopping distance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 513);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Skid analysis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton brakergl;
        private System.Windows.Forms.RadioButton brakelgr;
        private System.Windows.Forms.ComboBox skidsbackfront;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox skidsequal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tyrecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tyretype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox longwheel;
        private System.Windows.Forms.ComboBox vehicletype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private NumberBox skidfront;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox daytime;
        private System.Windows.Forms.ComboBox roadcover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox roadsurface;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button calculate;
        private NumberBox slopegrad;
        private System.Windows.Forms.Label slopelbl;
        private System.Windows.Forms.ComboBox roadslope;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox distinm;
        private NumberBox skidback;
        private System.Windows.Forms.Label distunit;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label equiv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox surfaceworn;
        private System.Windows.Forms.CheckBox ismph;
        private NumberBox collisionspeed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label speedunit;
        private System.Windows.Forms.Label minspeedbrake;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label theoryunit;
        private System.Windows.Forms.Label theorystop;
        private System.Windows.Forms.Label label20;
    }
}

