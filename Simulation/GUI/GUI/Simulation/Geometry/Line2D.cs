using System;

namespace GUI.Simulation.Geometry
{
    /// <summary>
    /// Line
    /// </summary>
    public class Line2D
    {
        /// <summary>
        /// Inclination angle of the line
        /// </summary>
        public Angle Inclination { get; private set; } = new Angle(0, Angle.Unit.Revolutions);

        /// <summary>
        /// Y intercept of the line
        /// </summary>
        public double Intercept_Y { get; private set; } = 0;

        /// <summary>
        /// Slope of the line
        /// </summary>
        public double Slope => Math.Tan(Inclination.Radian);

        /// <summary>
        /// returns the y coordinate for a given x coordinate lying on the line
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <returns>double</returns>
        public double Y(double x) => (Slope * x) + Intercept_Y;

        /// <summary>
        /// returns the x coordinate for a given y coordinate lying on the line
        /// </summary>
        /// <param name="y">y coordiante</param>
        /// <returns>double</returns>
        public double X(double y) => (y - Intercept_Y) / Slope;

        /// <summary>
        /// Creates a line with a known point and inclination angle
        /// </summary>
        /// <param name="point">known point on the line</param>
        /// <param name="inclination">inclination angle</param>
        public Line2D(Point2D point, Angle inclination) => Intercept_Y = point.Y - (Math.Tan((Inclination = inclination).Radian) * point.X);

        /// <summary>
        /// Creates a line with two known points
        /// </summary>
        /// <param name="point1">point 1</param>
        /// <param name="point2">point 2</param>
        public Line2D(Point2D point1, Point2D point2) => Intercept_Y = point1.Y - (Math.Tan((Inclination = Point2D.AngleOfElevation(point1, point2)).Radian) * point1.X);

        public Line2D(Line2D line)
        {
            Intercept_Y = line.Intercept_Y;
            Inclination = new Angle(line.Inclination);
        }

        // future update (return shortest distance from line and point)

        /// <summary>
        /// checks whether a specified point lies on a line
        /// </summary>
        /// <param name="line">line</param>
        /// <param name="point">point</param>
        /// <returns>bool</returns>
        public static bool PointLiesOnLine(Line2D line, Point2D point) => (point.Y == line.Y(point.X)) && (point.X == line.X(point.Y));

        /// <summary>
        /// checks whether a point specified lies on the line
        /// </summary>
        /// <param name="point">point</param>
        /// <returns>bool</returns>
        public bool PointLiesOnLine(Point2D point) => PointLiesOnLine(this, point);

        /// <summary>
        /// returns the angle between two lines. Line1.Angle - Line2.Angle
        /// </summary>
        /// <param name="line1">line 1</param>
        /// <param name="line2">line 2</param>
        /// <returns>Angle</returns>
        public static Angle AngleBetween(Line2D line1, Line2D line2) => line1.Inclination - line2.Inclination;

        /// <summary>
        /// returns the angle made between another line
        /// </summary>
        /// <param name="line">line</param>
        /// <returns>Angle</returns>
        public Angle AngleBetween(Line2D line) => AngleBetween(this, line);

        public override bool Equals(object obj) => obj.GetType() == GetType() ? ((Line2D)obj == this) : false;

        public override int GetHashCode() => (int)Math.Pow(Intercept_Y, Inclination._radByPI);

        public static bool operator ==(Line2D line1, Line2D line2) => (line1.Inclination == line2.Inclination) && (line1.Intercept_Y == line2.Intercept_Y);

        public static bool operator !=(Line2D line1, Line2D line2) => !(line1 == line2);

        public override string ToString() => Inclination + "  y-intercept: " + Intercept_Y;

    }

}
