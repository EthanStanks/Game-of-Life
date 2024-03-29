﻿
namespace Game_of_Life
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.universeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.CountNeighborsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.livingCellStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clickEvent1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickEvent2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel1 = new Game_of_Life.GraphicsPanel();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideNeighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideHeadsUpDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomUniTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetUniversesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ethanStanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gardenOfEdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gliderGunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.growByOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscillatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generationSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.universeToolStripMenuItem,
            this.viewStripMenuItem2,
            this.toolStripMenuItem1,
            this.ColorComboBox,
            this.CountNeighborsComboBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(144, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // universeToolStripMenuItem
            // 
            this.universeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.universeToolStripMenuItem.Name = "universeToolStripMenuItem";
            this.universeToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.universeToolStripMenuItem.Text = "&Settings";
            // 
            // viewStripMenuItem2
            // 
            this.viewStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideGridToolStripMenuItem,
            this.hideNeighborCountToolStripMenuItem,
            this.hideHeadsUpDisplayToolStripMenuItem});
            this.viewStripMenuItem2.Name = "viewStripMenuItem2";
            this.viewStripMenuItem2.Size = new System.Drawing.Size(44, 23);
            this.viewStripMenuItem2.Text = "&View";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomUniTimeToolStripMenuItem,
            this.raToolStripMenuItem,
            this.toolStripSeparator3,
            this.presetUniversesToolStripMenuItem,
            this.toolStripSeparator2,
            this.changeSizeToolStripMenuItem,
            this.generationSpeedToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 23);
            this.toolStripMenuItem1.Text = "&Universe";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Light Mode",
            "Dark Mode",
            "Bee Mode",
            "Turtle Mode",
            "Mr.Mime Mode",
            "Strawberry Mode"});
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(120, 23);
            this.ColorComboBox.ToolTipText = "Change Universe Color";
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // CountNeighborsComboBox
            // 
            this.CountNeighborsComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CountNeighborsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountNeighborsComboBox.Items.AddRange(new object[] {
            "Finite",
            "Toroidal"});
            this.CountNeighborsComboBox.Name = "CountNeighborsComboBox";
            this.CountNeighborsComboBox.Size = new System.Drawing.Size(121, 23);
            this.CountNeighborsComboBox.SelectedIndexChanged += new System.EventHandler(this.CountNeighborsComboBox_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator7,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1484, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "&Pause";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.livingCellStripStatusLabel1,
            this.toolStripStatusLabelSeed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 939);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1484, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // livingCellStripStatusLabel1
            // 
            this.livingCellStripStatusLabel1.Name = "livingCellStripStatusLabel1";
            this.livingCellStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.livingCellStripStatusLabel1.Text = "Cells Alive = 0";
            // 
            // toolStripStatusLabelSeed
            // 
            this.toolStripStatusLabelSeed.Name = "toolStripStatusLabelSeed";
            this.toolStripStatusLabelSeed.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabelSeed.Text = "Seed: 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickEvent1ToolStripMenuItem,
            this.clickEvent2ToolStripMenuItem,
            this.changeSizeToolStripMenuItem1,
            this.changeSpeedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 92);
            // 
            // clickEvent1ToolStripMenuItem
            // 
            this.clickEvent1ToolStripMenuItem.Name = "clickEvent1ToolStripMenuItem";
            this.clickEvent1ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clickEvent1ToolStripMenuItem.Text = "Random Uni (Time)";
            this.clickEvent1ToolStripMenuItem.Click += new System.EventHandler(this.clickEvent1ToolStripMenuItem_Click);
            // 
            // clickEvent2ToolStripMenuItem
            // 
            this.clickEvent2ToolStripMenuItem.Name = "clickEvent2ToolStripMenuItem";
            this.clickEvent2ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clickEvent2ToolStripMenuItem.Text = "Random Uni (Seed)";
            this.clickEvent2ToolStripMenuItem.Click += new System.EventHandler(this.clickEvent2ToolStripMenuItem_Click);
            // 
            // changeSizeToolStripMenuItem1
            // 
            this.changeSizeToolStripMenuItem1.Name = "changeSizeToolStripMenuItem1";
            this.changeSizeToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.changeSizeToolStripMenuItem1.Text = "Change Uni Size";
            this.changeSizeToolStripMenuItem1.Click += new System.EventHandler(this.changeSizeToolStripMenuItem1_Click);
            // 
            // changeSpeedToolStripMenuItem
            // 
            this.changeSpeedToolStripMenuItem.Name = "changeSpeedToolStripMenuItem";
            this.changeSpeedToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.changeSpeedToolStripMenuItem.Text = "Generation Speed";
            this.changeSpeedToolStripMenuItem.Click += new System.EventHandler(this.changeSpeedToolStripMenuItem_Click);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.Color.Silver;
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 52);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(1484, 887);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Game_of_Life.Properties.Resources.Run_16x;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "&Start";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Game_of_Life.Properties.Resources.Pause_16x;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "&Pause";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Game_of_Life.Properties.Resources.Next_16x;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "&Next";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Game_of_Life.Properties.Resources.FeedbackSmile_16x;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "&Portfolio";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.ImportFile_16x;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.importToolStripMenuItem.Text = "&Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.SaveAs_16x;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.Exit_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.ProcedureSettings_16x;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.reloadToolStripMenuItem.Text = "&Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.ProcedureMissing_16x;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // hideGridToolStripMenuItem
            // 
            this.hideGridToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.GridPane_16x;
            this.hideGridToolStripMenuItem.Name = "hideGridToolStripMenuItem";
            this.hideGridToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hideGridToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.hideGridToolStripMenuItem.Text = "Hide Grid";
            this.hideGridToolStripMenuItem.Click += new System.EventHandler(this.hideGridToolStripMenuItem_Click);
            // 
            // hideNeighborCountToolStripMenuItem
            // 
            this.hideNeighborCountToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.Counter_16x;
            this.hideNeighborCountToolStripMenuItem.Name = "hideNeighborCountToolStripMenuItem";
            this.hideNeighborCountToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.hideNeighborCountToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.hideNeighborCountToolStripMenuItem.Text = "Hide Neighbor Count";
            this.hideNeighborCountToolStripMenuItem.Click += new System.EventHandler(this.hideNeighborCountToolStripMenuItem_Click);
            // 
            // hideHeadsUpDisplayToolStripMenuItem
            // 
            this.hideHeadsUpDisplayToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.StatusInformation_16x;
            this.hideHeadsUpDisplayToolStripMenuItem.Name = "hideHeadsUpDisplayToolStripMenuItem";
            this.hideHeadsUpDisplayToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.hideHeadsUpDisplayToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.hideHeadsUpDisplayToolStripMenuItem.Text = "Hide HUD";
            this.hideHeadsUpDisplayToolStripMenuItem.Click += new System.EventHandler(this.hideHeadsUpDisplayToolStripMenuItem_Click);
            // 
            // randomUniTimeToolStripMenuItem
            // 
            this.randomUniTimeToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.Time_16x;
            this.randomUniTimeToolStripMenuItem.Name = "randomUniTimeToolStripMenuItem";
            this.randomUniTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randomUniTimeToolStripMenuItem.Text = "Random Uni (Time)";
            this.randomUniTimeToolStripMenuItem.Click += new System.EventHandler(this.randomUniTimeToolStripMenuItem_Click);
            // 
            // raToolStripMenuItem
            // 
            this.raToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.EditInput_16x;
            this.raToolStripMenuItem.Name = "raToolStripMenuItem";
            this.raToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raToolStripMenuItem.Text = "Random Uni (Seed)";
            this.raToolStripMenuItem.Click += new System.EventHandler(this.raToolStripMenuItem_Click);
            // 
            // presetUniversesToolStripMenuItem
            // 
            this.presetUniversesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ethanStanksToolStripMenuItem,
            this.gardenOfEdenToolStripMenuItem,
            this.germToolStripMenuItem,
            this.glassesToolStripMenuItem,
            this.gliderToolStripMenuItem,
            this.gliderGunToolStripMenuItem,
            this.growByOneToolStripMenuItem,
            this.oscillatorToolStripMenuItem,
            this.tToolStripMenuItem});
            this.presetUniversesToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.InkPresenter_16x;
            this.presetUniversesToolStripMenuItem.Name = "presetUniversesToolStripMenuItem";
            this.presetUniversesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.presetUniversesToolStripMenuItem.Text = "Custom Universes";
            // 
            // ethanStanksToolStripMenuItem
            // 
            this.ethanStanksToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.FillOpacity_16x;
            this.ethanStanksToolStripMenuItem.Name = "ethanStanksToolStripMenuItem";
            this.ethanStanksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ethanStanksToolStripMenuItem.Text = "Ethan Stanks";
            this.ethanStanksToolStripMenuItem.Click += new System.EventHandler(this.ethanStanksToolStripMenuItem_Click);
            // 
            // gardenOfEdenToolStripMenuItem
            // 
            this.gardenOfEdenToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.FillOpacity_16x;
            this.gardenOfEdenToolStripMenuItem.Name = "gardenOfEdenToolStripMenuItem";
            this.gardenOfEdenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gardenOfEdenToolStripMenuItem.Text = "Garden of Eden";
            this.gardenOfEdenToolStripMenuItem.Click += new System.EventHandler(this.gardenOfEdenToolStripMenuItem_Click);
            // 
            // germToolStripMenuItem
            // 
            this.germToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.FillOpacity_16x;
            this.germToolStripMenuItem.Name = "germToolStripMenuItem";
            this.germToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.germToolStripMenuItem.Text = "Germ";
            this.germToolStripMenuItem.Click += new System.EventHandler(this.germToolStripMenuItem_Click);
            // 
            // glassesToolStripMenuItem
            // 
            this.glassesToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.FillOpacity_16x;
            this.glassesToolStripMenuItem.Name = "glassesToolStripMenuItem";
            this.glassesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.glassesToolStripMenuItem.Text = "Glasses";
            this.glassesToolStripMenuItem.Click += new System.EventHandler(this.glassesToolStripMenuItem_Click);
            // 
            // gliderToolStripMenuItem
            // 
            this.gliderToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.FillOpacity_16x;
            this.gliderToolStripMenuItem.Name = "gliderToolStripMenuItem";
            this.gliderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gliderToolStripMenuItem.Text = "Glider";
            this.gliderToolStripMenuItem.Click += new System.EventHandler(this.gliderToolStripMenuItem_Click);
            // 
            // gliderGunToolStripMenuItem
            // 
            this.gliderGunToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.FillOpacity_16x;
            this.gliderGunToolStripMenuItem.Name = "gliderGunToolStripMenuItem";
            this.gliderGunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gliderGunToolStripMenuItem.Text = "Glider Gun";
            this.gliderGunToolStripMenuItem.Click += new System.EventHandler(this.gliderGunToolStripMenuItem_Click);
            // 
            // growByOneToolStripMenuItem
            // 
            this.growByOneToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.FillOpacity_16x;
            this.growByOneToolStripMenuItem.Name = "growByOneToolStripMenuItem";
            this.growByOneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.growByOneToolStripMenuItem.Text = "Grow-By-One";
            this.growByOneToolStripMenuItem.Click += new System.EventHandler(this.growByOneToolStripMenuItem_Click);
            // 
            // oscillatorToolStripMenuItem
            // 
            this.oscillatorToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.FillOpacity_16x;
            this.oscillatorToolStripMenuItem.Name = "oscillatorToolStripMenuItem";
            this.oscillatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oscillatorToolStripMenuItem.Text = "Oscillator";
            this.oscillatorToolStripMenuItem.Click += new System.EventHandler(this.oscillatorToolStripMenuItem_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.FillOpacity_16x;
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tToolStripMenuItem.Text = "T";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
            // 
            // changeSizeToolStripMenuItem
            // 
            this.changeSizeToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.Grid_16x;
            this.changeSizeToolStripMenuItem.Name = "changeSizeToolStripMenuItem";
            this.changeSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeSizeToolStripMenuItem.Text = "Change Uni Size";
            this.changeSizeToolStripMenuItem.Click += new System.EventHandler(this.changeSizeToolStripMenuItem_Click);
            // 
            // generationSpeedToolStripMenuItem
            // 
            this.generationSpeedToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.Timer_16x;
            this.generationSpeedToolStripMenuItem.Name = "generationSpeedToolStripMenuItem";
            this.generationSpeedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generationSpeedToolStripMenuItem.Text = "Generation Speed";
            this.generationSpeedToolStripMenuItem.Click += new System.EventHandler(this.generationSpeedToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life - Ethan Stanks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripComboBox ColorComboBox;
        private System.Windows.Forms.ToolStripComboBox CountNeighborsComboBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randomUniTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem generationSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideNeighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideHeadsUpDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel livingCellStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clickEvent1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickEvent2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetUniversesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ethanStanksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gliderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oscillatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem glassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gliderGunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem growByOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSeed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem gardenOfEdenToolStripMenuItem;
    }
}

