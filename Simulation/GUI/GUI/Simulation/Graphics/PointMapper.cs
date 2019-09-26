using System.Collections.Generic;
using System.Drawing;

using GUI.Simulation.Geometry;

namespace GUI.Simulation.Graphics
{
    public static class PointMapper
    {
        // has to  be updated every screen resize
        /// <summary>
        /// Origin Offset of Cartesian Origin from Screen Origin
        /// </summary>
        public static class Offset
        {
            /// <summary>
            /// X offset : X axis 0 on screen
            /// </summary>
            public static int X = 0;
            /// <summary>
            /// Y offset : Y axis 0 on screen
            /// </summary>
            public static int Y = 0;

            /// <summary>
            /// sets the cartesian offset (sets cartesian's origin point on screen coordinate system)
            /// </summary>
            /// <param name="x">X offset : X axis 0 on screen</param>
            /// <param name="y">Y offset : Y axis 0 on screen</param>
            public static void SetOffset(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        /// <summary>
        /// Coordinate axis flipping
        /// </summary>
        public static class CoordinateFlipping
        {
            /// <summary>
            /// Horizontal flip setting (default: false)
            /// </summary>
            public static bool Horizontal = false;
            public static byte __h_flip_factor => (byte)(Horizontal ? -1 : 1);
            
            /// <summary>
            /// Vertical flip setting (default: true)
            /// </summary>
            public static bool Vertical = false;
            public static byte __v_flip_factor => (byte)(Vertical ? -1 : 1);

            /// <summary>
            /// Sets the flip settings to default values: { H:0, V: 1 }
            /// </summary>
            public static void SetDefaults()
            {
                Horizontal = false;
                Vertical = true;
            }
        }

        /// <summary>
        /// Cartesian to Coordinate system size rescaler
        /// </summary>
        public static class Rescaler
        {

            private static double __value = 1;
            public static double Value
            {
                get => __value;
                set
                {
                    if (value < 0.01)
                        __value = 0.01;
                    else
                        __value = value;
                }
            }

            /// <summary>
            /// Set's to the default scale factor (1)
            /// </summary>
            public static void SetDefaults() => SetRescaleFactor(1);

            /// <summary>
            /// Sets the rescaling factor
            /// </summary>
            /// <param name="value">scale factor</param>
            public static void SetRescaleFactor(double value) => Value = value;
        }



        //public static Point TranslateToSystemPoint(Point2D cartesianPoint)
        //{
        //    return new Point
        //        (
        //            (int)(cartesianPoint.X * CoordinateFlipping.__h_flip_factor * Rescaler.HorizontalRescaleFactor) + Offset.X,
        //            (int)(cartesianPoint.Y * CoordinateFlipping.__v_flip_factor * Rescaler.VerticalRescaleFactor) + Offset.Y
        //        );
        //}

        public static Point TranslateToSystemPoint(Point2D cartesianPoint) 
            => new Point
                (
                    (int)(cartesianPoint.X * CoordinateFlipping.__h_flip_factor * Rescaler.Value) + Offset.X,
                    Offset.Y - (int)(cartesianPoint.Y * Rescaler.Value * CoordinateFlipping.__v_flip_factor)
                );



        public static Point[] TranslateToSystemPoint(Point2D[] cartesianPoints)
        {
            List<Point> pt_buffer = new List<Point>();

            foreach(Point2D cartesianPoint in cartesianPoints)
            {
                pt_buffer.Add(TranslateToSystemPoint(cartesianPoint));
            }

            return pt_buffer.ToArray();
        }

        public static Point2D TranslateToCartesianCoordinates(Point screenPoint)
            => new Point2D
            (
                (screenPoint.X - Offset.X) / (CoordinateFlipping.__h_flip_factor * Rescaler.Value), 
                (screenPoint.Y - Offset.Y) / (CoordinateFlipping.__v_flip_factor * Rescaler.Value)
            );

        public static Point2D[] TranslateToCartesianCoordinates(Point[] screenPoints)
        {
            List<Point2D> pt_buffer = new List<Point2D>();

            foreach(Point screenPoint in screenPoints)
            {
                pt_buffer.Add(TranslateToCartesianCoordinates(screenPoint));
            }

            return pt_buffer.ToArray();
        }

    }
}