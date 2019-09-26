namespace GUI.Simulation.UI
{
    partial class MainInterface
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
            this.panel18 = new System.Windows.Forms.Panel();
            this.status_label = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.appTitle = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_restore = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rnd_NumericSpawnInverse = new System.Windows.Forms.NumericUpDown();
            this.RandomGenerationCheckBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.RunSimulationButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.junctionListDock = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.frameBufferTimer = new System.Windows.Forms.Timer(this.components);
            this.JunctionViewContainer = new System.Windows.Forms.Panel();
            this.menustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mstrip_addNorthL = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleNorthRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrip_addSouth = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleSOUTHRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrip_addEast = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleEASTRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrip_addWest = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleWESTRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel18.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rnd_NumericSpawnInverse)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel12.SuspendLayout();
            this.junctionListDock.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel18.Controls.Add(this.status_label);
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel18.ForeColor = System.Drawing.Color.White;
            this.panel18.Location = new System.Drawing.Point(0, 780);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1664, 24);
            this.panel18.TabIndex = 9;
            // 
            // status_label
            // 
            this.status_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.status_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.status_label.Location = new System.Drawing.Point(0, 0);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(1408, 23);
            this.status_label.TabIndex = 3;
            this.status_label.Text = "   Software developed by: Rithvik Nishad. Not for redistribution.";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Black;
            this.panel19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel19.Location = new System.Drawing.Point(0, 23);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1664, 1);
            this.panel19.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1664, 1);
            this.panel2.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1628, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(36, 29);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "✖";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // appTitle
            // 
            this.appTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.appTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.appTitle.Location = new System.Drawing.Point(0, 0);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(430, 29);
            this.appTitle.TabIndex = 3;
            this.appTitle.Text = "  Smart Junction - Advanced Simulation Software";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_min
            // 
            this.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(1556, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(36, 29);
            this.btn_min.TabIndex = 7;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_restore);
            this.panel1.Controls.Add(this.appTitle);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1664, 30);
            this.panel1.TabIndex = 8;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_restore
            // 
            this.btn_restore.BackgroundImage = global::GUI.Properties.Resources.restorebtn_active;
            this.btn_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_restore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_restore.FlatAppearance.BorderSize = 0;
            this.btn_restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btn_restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.ForeColor = System.Drawing.Color.White;
            this.btn_restore.Location = new System.Drawing.Point(1592, 0);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(36, 29);
            this.btn_restore.TabIndex = 6;
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1664, 50);
            this.panel6.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel5.Controls.Add(this.rnd_NumericSpawnInverse);
            this.panel5.Controls.Add(this.RandomGenerationCheckBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(264, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1400, 25);
            this.panel5.TabIndex = 13;
            // 
            // rnd_NumericSpawnInverse
            // 
            this.rnd_NumericSpawnInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.rnd_NumericSpawnInverse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rnd_NumericSpawnInverse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rnd_NumericSpawnInverse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.rnd_NumericSpawnInverse.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rnd_NumericSpawnInverse.Location = new System.Drawing.Point(99, 4);
            this.rnd_NumericSpawnInverse.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.rnd_NumericSpawnInverse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rnd_NumericSpawnInverse.Name = "rnd_NumericSpawnInverse";
            this.rnd_NumericSpawnInverse.Size = new System.Drawing.Size(67, 19);
            this.rnd_NumericSpawnInverse.TabIndex = 1;
            this.rnd_NumericSpawnInverse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rnd_NumericSpawnInverse.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // RandomGenerationCheckBox
            // 
            this.RandomGenerationCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RandomGenerationCheckBox.AutoSize = true;
            this.RandomGenerationCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RandomGenerationCheckBox.FlatAppearance.BorderSize = 0;
            this.RandomGenerationCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomGenerationCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RandomGenerationCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.RandomGenerationCheckBox.Location = new System.Drawing.Point(0, 0);
            this.RandomGenerationCheckBox.Name = "RandomGenerationCheckBox";
            this.RandomGenerationCheckBox.Size = new System.Drawing.Size(93, 25);
            this.RandomGenerationCheckBox.TabIndex = 0;
            this.RandomGenerationCheckBox.Text = "  R A N D O M  ";
            this.RandomGenerationCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel4.Controls.Add(this.SettingsButton);
            this.panel4.Controls.Add(this.RunSimulationButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(264, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1400, 25);
            this.panel4.TabIndex = 12;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.SettingsButton.Location = new System.Drawing.Point(1292, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(108, 25);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = " S E T T I N G S    ";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // RunSimulationButton
            // 
            this.RunSimulationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RunSimulationButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RunSimulationButton.FlatAppearance.BorderSize = 0;
            this.RunSimulationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.RunSimulationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.RunSimulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunSimulationButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RunSimulationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.RunSimulationButton.Location = new System.Drawing.Point(0, 0);
            this.RunSimulationButton.Name = "RunSimulationButton";
            this.RunSimulationButton.Size = new System.Drawing.Size(93, 25);
            this.RunSimulationButton.TabIndex = 8;
            this.RunSimulationButton.Text = "  »   R U N";
            this.RunSimulationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RunSimulationButton.UseVisualStyleBackColor = true;
            this.RunSimulationButton.Click += new System.EventHandler(this.RunSimulationButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel17);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 50);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.array_hosting_network_rack_server_storage_system_icon_128;
            this.pictureBox1.Location = new System.Drawing.Point(13, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Black;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(263, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1, 50);
            this.panel17.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "c o n n e c t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.label4.Location = new System.Drawing.Point(54, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "S E R I A L   D E V I C E S";
            // 
            // panel12
            // 
            this.panel12.AutoScroll = true;
            this.panel12.Controls.Add(this.junctionListDock);
            this.panel12.Controls.Add(this.panel7);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.panel23);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 80);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(264, 700);
            this.panel12.TabIndex = 12;
            // 
            // junctionListDock
            // 
            this.junctionListDock.Controls.Add(this.panel10);
            this.junctionListDock.Controls.Add(this.panel8);
            this.junctionListDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.junctionListDock.Location = new System.Drawing.Point(0, 32);
            this.junctionListDock.Name = "junctionListDock";
            this.junctionListDock.Size = new System.Drawing.Size(262, 668);
            this.junctionListDock.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.OliveDrab;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.pictureBox3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 56);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(262, 56);
            this.panel10.TabIndex = 119;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.YellowGreen;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 54);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(262, 2);
            this.panel11.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "S M A R T   J U N C T I O N";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(49, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "@COM10 | Arduino Genuino Uno";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(11, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(262, 56);
            this.panel8.TabIndex = 118;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.YellowGreen;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 54);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(262, 2);
            this.panel9.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.label8.Location = new System.Drawing.Point(48, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "N O R M A L   J U N C T I O N";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(49, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "@COM3 | Arduino Genuino Uno";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(11, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 8);
            this.panel7.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(262, 24);
            this.panel13.TabIndex = 116;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.label3);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(131, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(131, 24);
            this.panel14.TabIndex = 114;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 22);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(131, 2);
            this.panel15.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Summary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.panel22);
            this.panel16.Controls.Add(this.label2);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(131, 24);
            this.panel16.TabIndex = 113;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(214)))));
            this.panel22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel22.Location = new System.Drawing.Point(0, 22);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(131, 2);
            this.panel22.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Junctions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.panel23.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel23.Location = new System.Drawing.Point(262, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(2, 700);
            this.panel23.TabIndex = 5;
            // 
            // frameBufferTimer
            // 
            this.frameBufferTimer.Enabled = true;
            this.frameBufferTimer.Interval = 40;
            this.frameBufferTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // JunctionViewContainer
            // 
            this.JunctionViewContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JunctionViewContainer.ContextMenuStrip = this.menustrip;
            this.JunctionViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JunctionViewContainer.Location = new System.Drawing.Point(264, 80);
            this.JunctionViewContainer.Name = "JunctionViewContainer";
            this.JunctionViewContainer.Size = new System.Drawing.Size(1400, 700);
            this.JunctionViewContainer.TabIndex = 15;
            // 
            // menustrip
            // 
            this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrip_addNorthL,
            this.addVehicleNorthRToolStripMenuItem,
            this.mstrip_addSouth,
            this.addVehicleSOUTHRToolStripMenuItem,
            this.mstrip_addEast,
            this.addVehicleEASTRToolStripMenuItem,
            this.mstrip_addWest,
            this.addVehicleWESTRToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menustrip.Name = "menustrip";
            this.menustrip.Size = new System.Drawing.Size(258, 208);
            // 
            // mstrip_addNorthL
            // 
            this.mstrip_addNorthL.Name = "mstrip_addNorthL";
            this.mstrip_addNorthL.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.mstrip_addNorthL.Size = new System.Drawing.Size(257, 22);
            this.mstrip_addNorthL.Text = "Add Vehicle NORTH (L)";
            this.mstrip_addNorthL.Click += new System.EventHandler(this.mstrip_addNorthL_Click);
            // 
            // addVehicleNorthRToolStripMenuItem
            // 
            this.addVehicleNorthRToolStripMenuItem.Name = "addVehicleNorthRToolStripMenuItem";
            this.addVehicleNorthRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.addVehicleNorthRToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.addVehicleNorthRToolStripMenuItem.Text = "Add Vehicle NORTH (R)";
            this.addVehicleNorthRToolStripMenuItem.Click += new System.EventHandler(this.addVehicleNorthRToolStripMenuItem_Click);
            // 
            // mstrip_addSouth
            // 
            this.mstrip_addSouth.Name = "mstrip_addSouth";
            this.mstrip_addSouth.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.mstrip_addSouth.Size = new System.Drawing.Size(257, 22);
            this.mstrip_addSouth.Text = "Add Vehicle SOUTH (L)";
            this.mstrip_addSouth.Click += new System.EventHandler(this.mstrip_addSouth_Click);
            // 
            // addVehicleSOUTHRToolStripMenuItem
            // 
            this.addVehicleSOUTHRToolStripMenuItem.Name = "addVehicleSOUTHRToolStripMenuItem";
            this.addVehicleSOUTHRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.addVehicleSOUTHRToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.addVehicleSOUTHRToolStripMenuItem.Text = "Add Vehicle SOUTH (R)";
            this.addVehicleSOUTHRToolStripMenuItem.Click += new System.EventHandler(this.addVehicleSOUTHRToolStripMenuItem_Click);
            // 
            // mstrip_addEast
            // 
            this.mstrip_addEast.Name = "mstrip_addEast";
            this.mstrip_addEast.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.mstrip_addEast.Size = new System.Drawing.Size(257, 22);
            this.mstrip_addEast.Text = "Add Vehicle EAST (L)";
            this.mstrip_addEast.Click += new System.EventHandler(this.mstrip_addEast_Click);
            // 
            // addVehicleEASTRToolStripMenuItem
            // 
            this.addVehicleEASTRToolStripMenuItem.Name = "addVehicleEASTRToolStripMenuItem";
            this.addVehicleEASTRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Up)));
            this.addVehicleEASTRToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.addVehicleEASTRToolStripMenuItem.Text = "Add Vehicle EAST (R)";
            this.addVehicleEASTRToolStripMenuItem.Click += new System.EventHandler(this.addVehicleEASTRToolStripMenuItem_Click);
            // 
            // mstrip_addWest
            // 
            this.mstrip_addWest.Name = "mstrip_addWest";
            this.mstrip_addWest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.mstrip_addWest.Size = new System.Drawing.Size(257, 22);
            this.mstrip_addWest.Text = "Add Vehicle WEST (L)";
            this.mstrip_addWest.Click += new System.EventHandler(this.mstrip_addWest_Click);
            // 
            // addVehicleWESTRToolStripMenuItem
            // 
            this.addVehicleWESTRToolStripMenuItem.Name = "addVehicleWESTRToolStripMenuItem";
            this.addVehicleWESTRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)));
            this.addVehicleWESTRToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.addVehicleWESTRToolStripMenuItem.Text = "Add Vehicle WEST (R)";
            this.addVehicleWESTRToolStripMenuItem.Click += new System.EventHandler(this.addVehicleWESTRToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // simulationTimer
            // 
            this.simulationTimer.Interval = 40;
            this.simulationTimer.Tick += new System.EventHandler(this.simulationTimer_Tick);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1664, 804);
            this.ContextMenuStrip = this.menustrip;
            this.Controls.Add(this.JunctionViewContainer);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel18);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Junction - Advanced Simulation Software";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.SizeChanged += new System.EventHandler(this.MainInterface_SizeChanged);
            this.panel18.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rnd_NumericSpawnInverse)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.junctionListDock.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.menustrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button RunSimulationButton;
        private System.Windows.Forms.Timer frameBufferTimer;
        private System.Windows.Forms.Panel JunctionViewContainer;
        private System.Windows.Forms.ContextMenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem mstrip_addNorthL;
        private System.Windows.Forms.ToolStripMenuItem mstrip_addSouth;
        private System.Windows.Forms.ToolStripMenuItem mstrip_addEast;
        private System.Windows.Forms.ToolStripMenuItem mstrip_addWest;
        private System.Windows.Forms.ToolStripMenuItem addVehicleNorthRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleSOUTHRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleEASTRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleWESTRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox RandomGenerationCheckBox;
        private System.Windows.Forms.NumericUpDown rnd_NumericSpawnInverse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Timer simulationTimer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel junctionListDock;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}