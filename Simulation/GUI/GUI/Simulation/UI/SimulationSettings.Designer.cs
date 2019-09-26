namespace GUI.Simulation.UI
{
    partial class SimulationSettings
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
            this.status_label = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.appTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.JunctionViewContainer = new System.Windows.Forms.Panel();
            this.logfilesavelocationtextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericSimulationComputeRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Numeric_ComputeInterval = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Numeric_FrameBufferRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel18.SuspendLayout();
            this.JunctionViewContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSimulationComputeRefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_ComputeInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_FrameBufferRefreshInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // status_label
            // 
            this.status_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.status_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.status_label.Location = new System.Drawing.Point(0, 0);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(473, 23);
            this.status_label.TabIndex = 3;
            this.status_label.Text = "   Version:";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Black;
            this.panel19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel19.Location = new System.Drawing.Point(0, 23);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(731, 1);
            this.panel19.TabIndex = 1;
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
            this.btn_close.Location = new System.Drawing.Point(695, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(36, 29);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "✖";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 1);
            this.panel2.TabIndex = 1;
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
            this.appTitle.Text = "  Smart Junction - Simulation Settings";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(731, 38);
            this.panel6.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(554, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save && Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.panel17);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 38);
            this.panel3.TabIndex = 11;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Black;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(263, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1, 38);
            this.panel17.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::GUI.Properties.Resources.config1;
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 26);
            this.label6.TabIndex = 17;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "S e t t i n g s";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.appTitle);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 30);
            this.panel1.TabIndex = 16;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel18.Controls.Add(this.status_label);
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel18.ForeColor = System.Drawing.Color.White;
            this.panel18.Location = new System.Drawing.Point(0, 278);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(731, 24);
            this.panel18.TabIndex = 17;
            // 
            // JunctionViewContainer
            // 
            this.JunctionViewContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.JunctionViewContainer.Controls.Add(this.label9);
            this.JunctionViewContainer.Controls.Add(this.logfilesavelocationtextbox);
            this.JunctionViewContainer.Controls.Add(this.label4);
            this.JunctionViewContainer.Controls.Add(this.label3);
            this.JunctionViewContainer.Controls.Add(this.label2);
            this.JunctionViewContainer.Controls.Add(this.NumericSimulationComputeRefreshRate);
            this.JunctionViewContainer.Controls.Add(this.label8);
            this.JunctionViewContainer.Controls.Add(this.Numeric_ComputeInterval);
            this.JunctionViewContainer.Controls.Add(this.label7);
            this.JunctionViewContainer.Controls.Add(this.Numeric_FrameBufferRefreshInterval);
            this.JunctionViewContainer.Controls.Add(this.label1);
            this.JunctionViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JunctionViewContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.JunctionViewContainer.Location = new System.Drawing.Point(0, 68);
            this.JunctionViewContainer.Name = "JunctionViewContainer";
            this.JunctionViewContainer.Size = new System.Drawing.Size(731, 210);
            this.JunctionViewContainer.TabIndex = 20;
            // 
            // logfilesavelocationtextbox
            // 
            this.logfilesavelocationtextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logfilesavelocationtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logfilesavelocationtextbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logfilesavelocationtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.logfilesavelocationtextbox.Location = new System.Drawing.Point(218, 153);
            this.logfilesavelocationtextbox.Name = "logfilesavelocationtextbox";
            this.logfilesavelocationtextbox.Size = new System.Drawing.Size(385, 15);
            this.logfilesavelocationtextbox.TabIndex = 29;
            this.logfilesavelocationtextbox.Text = "Default Log File Save Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Save log files into folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.label3.Location = new System.Drawing.Point(298, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Simulation Refresh Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.label2.Location = new System.Drawing.Point(298, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Compute Accuracy (higher => more accuraccy)\r\nAlso creates simulation time warp.";
            // 
            // NumericSimulationComputeRefreshRate
            // 
            this.NumericSimulationComputeRefreshRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumericSimulationComputeRefreshRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumericSimulationComputeRefreshRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericSimulationComputeRefreshRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.NumericSimulationComputeRefreshRate.Location = new System.Drawing.Point(218, 105);
            this.NumericSimulationComputeRefreshRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericSimulationComputeRefreshRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericSimulationComputeRefreshRate.Name = "NumericSimulationComputeRefreshRate";
            this.NumericSimulationComputeRefreshRate.Size = new System.Drawing.Size(74, 19);
            this.NumericSimulationComputeRefreshRate.TabIndex = 25;
            this.NumericSimulationComputeRefreshRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericSimulationComputeRefreshRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.label8.Location = new System.Drawing.Point(18, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Simulation Compute Refresh Rate: ";
            // 
            // Numeric_ComputeInterval
            // 
            this.Numeric_ComputeInterval.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Numeric_ComputeInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numeric_ComputeInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Numeric_ComputeInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.Numeric_ComputeInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numeric_ComputeInterval.Location = new System.Drawing.Point(218, 74);
            this.Numeric_ComputeInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Numeric_ComputeInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Numeric_ComputeInterval.Name = "Numeric_ComputeInterval";
            this.Numeric_ComputeInterval.Size = new System.Drawing.Size(74, 19);
            this.Numeric_ComputeInterval.TabIndex = 23;
            this.Numeric_ComputeInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Numeric_ComputeInterval.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(18, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Simulation Compute Interval: ";
            // 
            // Numeric_FrameBufferRefreshInterval
            // 
            this.Numeric_FrameBufferRefreshInterval.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Numeric_FrameBufferRefreshInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numeric_FrameBufferRefreshInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Numeric_FrameBufferRefreshInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.Numeric_FrameBufferRefreshInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Numeric_FrameBufferRefreshInterval.Location = new System.Drawing.Point(218, 43);
            this.Numeric_FrameBufferRefreshInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Numeric_FrameBufferRefreshInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Numeric_FrameBufferRefreshInterval.Name = "Numeric_FrameBufferRefreshInterval";
            this.Numeric_FrameBufferRefreshInterval.Size = new System.Drawing.Size(74, 19);
            this.Numeric_FrameBufferRefreshInterval.TabIndex = 20;
            this.Numeric_FrameBufferRefreshInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Numeric_FrameBufferRefreshInterval.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Frame Buffer Resfresh Interval: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(177)))));
            this.label9.Location = new System.Drawing.Point(298, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Graphics output, refresh interval";
            // 
            // SimulationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 302);
            this.ControlBox = false;
            this.Controls.Add(this.JunctionViewContainer);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel18);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimulationSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SimulationSettings_Load);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.JunctionViewContainer.ResumeLayout(false);
            this.JunctionViewContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSimulationComputeRefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_ComputeInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_FrameBufferRefreshInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel JunctionViewContainer;
        private System.Windows.Forms.NumericUpDown NumericSimulationComputeRefreshRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Numeric_ComputeInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Numeric_FrameBufferRefreshInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logfilesavelocationtextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}