using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GUI;
using GUI.Simulation;
using GUI.Simulation.Terrains;
using GUI.Simulation.Geometry;
using GUI.Simulation.Graphics;

namespace GUI.Simulation.UI.Objects
{
    public partial class Junction : Form
    {

        public Simulation Simulation;


        public static Pen Pens_RoadYellowLine = new Pen(Color.FromArgb(255, 192, 0), 2);
        public static Pen Pens_ZebraLine = new Pen(Color.WhiteSmoke, 6);
        public static SolidBrush Brush_Road = new SolidBrush(Color.FromArgb(42, 42, 44));


        public Junction(string junctionID, System.IO.Ports.SerialPort serialport)
        {
            InitializeComponent();

            MouseWheel += new MouseEventHandler(Junction_MouseWheel);

            PointMapper.Offset.SetOffset(Size.Width / 2, Size.Height / 2);
            PointMapper.Rescaler.SetRescaleFactor(10);

            Simulation = new Simulation(junctionID, serialport);
            Text = junctionID;
        }

        private void Junction_MouseWheel(object sender, MouseEventArgs e)
        {
            PointMapper.Rescaler.SetRescaleFactor(PointMapper.Rescaler.Value + ((e.Delta / Math.Abs(e.Delta))));
            Refresh();
        }

        public void Buffer()
        {
            Text = Simulation.JunctionID + " - uptime: " + Simulation.Uptime.ToString();
            label_junctionID.Text = Text;
            Refresh();
        }

        public void FlushLog()
        {
            Simulation.FlushLog();
        }


        private void Junction_Paint(object sender, PaintEventArgs e)
        {
            PointMapper.Offset.SetOffset(Size.Width / 2, Size.Height / 2);

            System.Drawing.Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            foreach (Rectangle2D channel in SampleJunction.AllChannelBound)
            {
                graphics.FillPolygon(Brush_Road, GlobalAdapter.TransformToPolygon(channel).Vertices);
            }
            graphics.FillPolygon(Brush_Road, GlobalAdapter.TransformToPolygon(SampleJunction.Junction_BOX).Vertices);

            foreach (Rectangle2D road in SampleJunction.AllChannelBound)
            {
                LineSegment2D border = (new LineSegment2D(road.AD)).Move(10, road.Inclination + Angle.A270);
                graphics.DrawLine(new Pen(Color.FromArgb(28, 28, 28), 10), PointMapper.TranslateToSystemPoint(border.A), PointMapper.TranslateToSystemPoint(border.B));
            }

            foreach (Rectangle2D road in SampleJunction.EntryBounds)
            {
                LineSegment2D yellow_left = (new LineSegment2D(road.AD)).Move(0.8, road.Inclination + Angle.A270);
                graphics.DrawLine(Pens_RoadYellowLine, PointMapper.TranslateToSystemPoint(new Point2D(yellow_left.A).Move(10, road.Inclination)), PointMapper.TranslateToSystemPoint(yellow_left.B));

                LineSegment2D yellow_right = (new LineSegment2D(road.BC)).Move(1.3, road.Inclination + Angle.A90);
                graphics.DrawLine(Pens_RoadYellowLine, PointMapper.TranslateToSystemPoint(new Point2D(yellow_right.A)), PointMapper.TranslateToSystemPoint(yellow_right.B));

                LineSegment2D ZebraLine = new LineSegment2D(new Point2D(yellow_left.A), new Point2D(yellow_left.A).Move(5, road.Inclination - Angle.A180)).Move(0.9, road.Inclination + Angle.A270);
                graphics.DrawLine(Pens_ZebraLine, PointMapper.TranslateToSystemPoint(ZebraLine.A), PointMapper.TranslateToSystemPoint(ZebraLine.B));
                for (int i = 0; i < 5; ++i)
                    graphics.DrawLine(Pens_ZebraLine, PointMapper.TranslateToSystemPoint(ZebraLine.A.Move(1.2, road.Inclination - Angle.A90)), PointMapper.TranslateToSystemPoint(ZebraLine.B.Move(1.2, road.Inclination - Angle.A90)));

                LineSegment2D EntryLine = new LineSegment2D(new Point2D(yellow_left.A).Move(6, road.Inclination - Angle.A180), new Point2D(yellow_right.A).Move(6, road.Inclination - Angle.A180)).Shirnk(-.25);

                graphics.DrawLine(Pens_ZebraLine, PointMapper.TranslateToSystemPoint(EntryLine.A), PointMapper.TranslateToSystemPoint(EntryLine.B));
            }

            foreach (Rectangle2D road in SampleJunction.ExitBounds)
            {
                LineSegment2D yellow_left = (new LineSegment2D(road.AD)).Move(0.8, road.Inclination + Angle.A270);
                graphics.DrawLine(Pens_RoadYellowLine, PointMapper.TranslateToSystemPoint(new Point2D(yellow_left.A)), PointMapper.TranslateToSystemPoint(new Point2D(yellow_left.B).Move(10, road.Inclination - Angle.A180)));

                LineSegment2D yellow_right = (new LineSegment2D(road.BC)).Move(1.3, road.Inclination + Angle.A90);
                graphics.DrawLine(Pens_RoadYellowLine, PointMapper.TranslateToSystemPoint(new Point2D(yellow_right.A)), PointMapper.TranslateToSystemPoint(new Point2D(yellow_right.B)));

                LineSegment2D ZebraLine = new LineSegment2D(yellow_left.B, new Point2D(yellow_left.B).Move(5, road.Inclination)).Move(0.9, road.Inclination + Angle.A270);
                graphics.DrawLine(Pens_ZebraLine, PointMapper.TranslateToSystemPoint(ZebraLine.A), PointMapper.TranslateToSystemPoint(ZebraLine.B));
                for (int i = 0; i < 5; ++i)
                    graphics.DrawLine(Pens_ZebraLine, PointMapper.TranslateToSystemPoint(ZebraLine.A.Move(1.2, road.Inclination - Angle.A90)), PointMapper.TranslateToSystemPoint(ZebraLine.B.Move(1.2, road.Inclination - Angle.A90)));
            }

            foreach (GUI.Simulation.Roads.Road road in Simulation.Roads)
            {
                foreach (GUI.Simulation.Vehicles.Vehicle vehicle in road.LeftLane.Vehicles)
                {
                    SolidBrush __brush;

                    if (road.SignalState == 'G')
                        __brush = new SolidBrush(Color.Green);
                    else if (road.SignalState == 'Y')
                        __brush = new SolidBrush(Color.Yellow);
                    else if (road.SignalState == 'R')
                        __brush = new SolidBrush(Color.Red);
                    else
                        __brush = new SolidBrush(Color.Gray);

                    //if (vehicle.DurationWait > 15)
                    //    __brush = new SolidBrush(Color.Red);
                    //else
                    //    __brush = new SolidBrush(Color.RoyalBlue);
                    graphics.FillPolygon(__brush, GlobalAdapter.TransformToPolygon(vehicle.CurrentBound).Vertices);
                    graphics.DrawLine(new Pen(Color.FromArgb(50, 50, 50), 2), PointMapper.TranslateToSystemPoint(vehicle.Position), PointMapper.TranslateToSystemPoint(vehicle.BrakeVector));
                    //graphics.DrawString(vehicle.Speed.ToString(), new Font("Calibri", 9), new SolidBrush(Color.Green), PointMapper.TranslateToSystemPoint(vehicle.Position));
                }

                foreach (GUI.Simulation.Vehicles.Vehicle vehicle in road.RightLane.Vehicles)
                {
                    SolidBrush __brush;

                    if (road.SignalState == 'G')
                        __brush = new SolidBrush(Color.Green);
                    else if (road.SignalState == 'Y')
                        __brush = new SolidBrush(Color.Yellow);
                    else if (road.SignalState == 'R')
                        __brush = new SolidBrush(Color.Red);
                    else
                        __brush = new SolidBrush(Color.Gray);

                    //if (vehicle.DurationWait > 15)
                    //    __brush = new SolidBrush(Color.Red);
                    //else
                    //    __brush = new SolidBrush(Color.RoyalBlue);
                    graphics.FillPolygon(__brush, GlobalAdapter.TransformToPolygon(vehicle.CurrentBound).Vertices);
                    graphics.DrawLine(new Pen(Color.FromArgb(50, 50, 50), 2), PointMapper.TranslateToSystemPoint(vehicle.Position), PointMapper.TranslateToSystemPoint(vehicle.BrakeVector));
                    //graphics.DrawString(vehicle.Speed.ToString(), new Font("Calibri", 9), new SolidBrush(Color.Green), PointMapper.TranslateToSystemPoint(vehicle.Position));
                }
            }
            avgTime.Text = Math.Round(Simulation.AverageWaitTime.AverageValue, 2).ToString() + " s";
        }
    }
}
