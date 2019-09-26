using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using GUI.Simulation.Terrains;
using GUI.Simulation.Geometry;
using GUI.Simulation.Graphics;
using GUI.Simulation.Vehicles;
using GUI.Simulation.Drivers;
using GUI.Simulation.UI.Objects;

namespace GUI.Simulation.UI
{

    public partial class MainInterface : Form
    {
        public List<Junction> Junctions = new List<Junction>();

        public MainInterface()
        {
            InitializeComponent();
            MouseWheel += new MouseEventHandler(MainInterface_MouseWheel);
        }

        SerialPort emergency_serialport;
        SerialPort smrtjnc_serialport;
        SerialPort normaljnc_serialport;

        private void MainInterface_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogPath = Application.StartupPath;

            emergency_serialport = new SerialPort("COM26", 9600);

            smrtjnc_serialport = new SerialPort("COM10", 2000000);
            normaljnc_serialport = new SerialPort("COM3", 2000000);

            emergency_serialport.Open();
            smrtjnc_serialport.Open();
            normaljnc_serialport.Open();

            Junction smrtjnc_mstr = new Junction("SMRTJNC", smrtjnc_serialport);
            Junction normal_junction = new Junction("normal_junction", normaljnc_serialport);

            smrtjnc_mstr.TopLevel = false;
            normal_junction.TopLevel = false;

            Junctions.Add(normal_junction);
            Junctions.Add(smrtjnc_mstr);

            normal_junction.Dock = DockStyle.Left;
            smrtjnc_mstr.Dock = DockStyle.Right;

            smrtjnc_mstr.Show();
            normal_junction.Show();

            foreach (Junction junction in Junctions)
            {
                junction.TopLevel = false;
                JunctionViewContainer.Controls.Add(junction);
                junction.Show();
            }
        }

        private void MainInterface_MouseWheel(object sender, MouseEventArgs e)
        {
            PointMapper.Rescaler.SetRescaleFactor(PointMapper.Rescaler.Value + ((e.Delta / Math.Abs(e.Delta)) * 0.1));
            //scaleLabel.Text = "Rescale: " + (int)(PointMapper.Rescaler.Value * 100) + "%";
        }

        public void TerminateSoftware()
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_close_Click(object sender, EventArgs e) => TerminateSoftware();

        private void btn_restore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
                rect.Location = new Point(0, 0);
                MaximizedBounds = rect;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_min_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void RunSimulationButton_Click(object sender, EventArgs e)
        {
            RunSimulationButton.Text = (simulationTimer.Enabled = !simulationTimer.Enabled) ? "  ■   P A U S E" : "  »   R U N";
            foreach(Junction junction in Junctions)
            {
                junction.FlushLog();
            }
            emergency_serialport.WriteLine("AT+CMGF=1\r\n");
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            foreach(Junction junction in Junctions)
            {
                junction.Buffer();
            }
        }

        private void mstrip_addNorthL_Click(object sender, EventArgs e)
        {
            Driver driver = WorldDrivers.GetRandomDriver();
            VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
            foreach (Junction junction in Junctions)
            {
                junction.Simulation.Roads[0].LeftLane.AddVehicleManual(driver, vehicleSpecs);
            }
        }

        private void addVehicleNorthRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver driver = WorldDrivers.GetRandomDriver();
            VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
            foreach (Junction junction in Junctions)
            {
                junction.Simulation.Roads[0].RightLane.AddVehicleManual(driver, vehicleSpecs);
            }
        }

        private void mstrip_addSouth_Click(object sender, EventArgs e)
        {
            Driver driver = WorldDrivers.GetRandomDriver();
            VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
            foreach (Junction junction in Junctions)
            {
                junction.Simulation.Roads[1].LeftLane.AddVehicleManual(driver, vehicleSpecs);
            }
        }

        private void addVehicleSOUTHRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver driver = WorldDrivers.GetRandomDriver();
            VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
            foreach (Junction junction in Junctions)
            {
                junction.Simulation.Roads[1].RightLane.AddVehicleManual(driver, vehicleSpecs);
            }
        }

        private void mstrip_addEast_Click(object sender, EventArgs e)
        {
            Driver driver = WorldDrivers.GetRandomDriver();
            VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
            foreach (Junction junction in Junctions)
            {
                junction.Simulation.Roads[2].LeftLane.AddVehicleManual(driver, vehicleSpecs);
            }
        }

        private void addVehicleEASTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver driver = WorldDrivers.GetRandomDriver();
            VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
            foreach (Junction junction in Junctions)
            {
                junction.Simulation.Roads[2].RightLane.AddVehicleManual(driver, vehicleSpecs);
            }
        }

        private void mstrip_addWest_Click(object sender, EventArgs e)
        {
            Driver driver = WorldDrivers.GetRandomDriver();
            VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
            foreach (Junction junction in Junctions)
            {
                junction.Simulation.Roads[3].LeftLane.AddVehicleManual(driver, vehicleSpecs);
            }
        }

        private void addVehicleWESTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver driver = WorldDrivers.GetRandomDriver();
            VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
            foreach (Junction junction in Junctions)
            {
                junction.Simulation.Roads[3].RightLane.AddVehicleManual(driver, vehicleSpecs);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => TerminateSoftware();

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SimulationSettings simulationSettings = new SimulationSettings();
            simulationSettings.Show();
        }

        private bool RandomSpawnNow() => Tools.RandomNumber((int)rnd_NumericSpawnInverse.Value) == 0;

        private void AddVehicleRandom()
        {

            for (int i = 0; i < 4; ++i)
            {
                if (RandomSpawnNow())
                {
                    Driver driver = WorldDrivers.GetRandomDriver();
                    VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
                    foreach (Junction junction in Junctions)
                    {
                        junction.Simulation.Roads[i].LeftLane.AddVehicleManual(driver, vehicleSpecs);
                    }
                }

                if (RandomSpawnNow())
                {
                    Driver driver = WorldDrivers.GetRandomDriver();
                    VehicleSpecs vehicleSpecs = VehicleModels.GetRandomCar();
                    foreach (Junction junction in Junctions)
                    {
                        junction.Simulation.Roads[i].RightLane.AddVehicleManual(driver, vehicleSpecs);
                    }
                }
            }
            
        }

        private char buff = 'n';

        private string emergency_buffer;

        private void simulationTimer_Tick(object sender, EventArgs e)
        {
            frameBufferTimer.Interval = Properties.Settings.Default.Simulation_FrameBufferRefreshInterval;
            simulationTimer.Interval = Properties.Settings.Default.Simulation_ComputeInterval;

            foreach (Junction junction in Junctions)
                junction.Simulation.Refresh();

            while (emergency_serialport.BytesToRead > 0)
            {
                // format: $em:"#Exy<z>";
                buff = (char)emergency_serialport.ReadChar();
                Console.Write(buff);
                if (buff == '$')
                {
                    Console.Write(buff);
                    buff = (char)emergency_serialport.ReadChar();
                    if (buff == 'e')
                    {
                        Console.Write(buff);
                        buff = (char)emergency_serialport.ReadChar();
                        if (buff == 'm')
                        {
                            Console.Write(buff);
                            buff = (char)emergency_serialport.ReadChar();
                            if (buff == ':')
                            {
                                Console.Write(buff);
                                buff = (char)emergency_serialport.ReadChar();
                                if (buff == '"')
                                {
                                    emergency_buffer = emergency_serialport.ReadTo("\"");
                                    Console.WriteLine("\n" + emergency_buffer + "\n");
                                    if (emergency_serialport.ReadChar() == ';')
                                    {
                                        smrtjnc_serialport.Write(emergency_buffer);
                                        emergency_buffer = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (RandomGenerationCheckBox.Checked)
                AddVehicleRandom();

            status_label.Text = "   Software developed by: Rithvik Nishad. Not for redistribution.   |   Simulation Time:  " + DateTime.Now.TimeOfDay;
        }

        private void MainInterface_SizeChanged(object sender, EventArgs e)
        {
            Size bufferWindowSize = new Size(JunctionViewContainer.Size.Width / 2, JunctionViewContainer.Size.Height);

            foreach (Junction junction in Junctions)
            {
                junction.Size = bufferWindowSize;
                junction.Buffer();
            }
        }
    }
}
