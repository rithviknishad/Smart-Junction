using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Simulation.UI
{

    public partial class SimulationSettings : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        


        public SimulationSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Simulation_FrameBufferRefreshInterval = (int)Numeric_FrameBufferRefreshInterval.Value;
            Properties.Settings.Default.Simulation_ComputeInterval = (int)Numeric_ComputeInterval.Value;
            Properties.Settings.Default.Simulation_ComputeAccuraccy = (int)NumericSimulationComputeRefreshRate.Value;
            Properties.Settings.Default.LogPath = logfilesavelocationtextbox.Text;

            Properties.Settings.Default.Save();
        }

        private void SimulationSettings_Load(object sender, EventArgs e)
        {
            status_label.Text = "   Application Version:  " + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + " [Build: " + Assembly.GetExecutingAssembly().GetName().Version.Build.ToString() + "  Revision: " + Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString() + "]";
            Numeric_FrameBufferRefreshInterval.Value = Properties.Settings.Default.Simulation_FrameBufferRefreshInterval;
            Numeric_ComputeInterval.Value = Properties.Settings.Default.Simulation_ComputeInterval;
            NumericSimulationComputeRefreshRate.Value = Properties.Settings.Default.Simulation_ComputeAccuraccy;
            logfilesavelocationtextbox.Text = Properties.Settings.Default.LogPath;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
