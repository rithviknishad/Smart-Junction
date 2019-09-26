using System;
using GUI.Mathematical_Tools;

namespace GUI.Simulation.Geometry
{
    /// <summary>
    /// Point class for defining coordinate system
    /// </summary>
    public partial class Point2D
    {
        /// <summary>
        /// X co-ordinate of the point (Vertical displacement)
        /// </summary>
        public double X { get; private set; } = 0;

        /// <summary>
        /// Y co-ordinate of the point (Horizontal displacement)
        /// </summary>
        public double Y { get; private set; } = 0;


        /// <summary>
        /// Creates a Point2D object with it's coordinates specified
        /// </summary>
        /// <param name="x">X co-ordinate of the point</param>
        /// <param name="y">Y co-ordinate of the point</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Creates a Point2D object with another point specified
        /// </summary>
        /// <param name="point">Point2D object from which the new Point2D to be created from</param>
        public Point2D(Point2D point)
        {
            X = point.X;
            Y = point.Y;
        }

        /// <summary>
        /// Point2D (0, 0)
        /// </summary>
        public static Point2D Origin => new Point2D(0, 0);


        /// <summary>
        /// Moves a specified Point2D object by a distance, through an angle from x-axis and also returns a new Point2D object of the same after moving
        /// </summary>
        /// <param name="point">Point2D object to be moved</param>
        /// <param name="distance">distance to move</param>
        /// <param name="angle">angle between the displacement vector and X-axis</param>
        /// <returns>Point2D</returns>
        public static Point2D Move(Point2D point, double distance, Angle angle) => new Point2D(point.X += distance * Math.Cos(angle.Radian), point.Y += distance * Math.Sin(angle.Radian));

        /// <summary>
        /// Moves a specified Point2D object by a distance, parallel to x-axis and also returns a new Point2D object of the same after moving
        /// </summary>
        /// <param name="point">Point2D object to be moved</param>
        /// <param name="distance">distance to move</param>
        /// <returns>Point2D</returns>
        public static Point2D MoveX(Point2D point, double distance) => Move(point, distance, new Angle(0, Angle.Unit.Degrees));

        /// <summary>
        /// Moves a specified Point2D object by a distance, parallel to y-axis and also returns a new Point2D object of he same after moving
        /// </summary>
        /// <param name="point">Point2D object to be moved</param>
        /// <param name="distance">distance to move</param>
        /// <returns>Point2D</returns>
        public static Point2D MoveY(Point2D point, double distance) => Move(point, distance, new Angle(90, Angle.Unit.Degrees));


        /// <summary>
        /// Moves by a distance, through an angle from x-axis and also returns a new Point2D object of the same after moving
        /// </summary>
        /// <param name="distance">distance to move</param>
        /// <param name="angle">angle between the displacement vector and X-axis</param>
        /// <returns>Point2D</returns>
        public Point2D Move(double distance, Angle angle) => Move(this, distance, angle);

        /// <summary>
        /// Moves by a distance, parallel to x-axis and also returns a new Point2D object of the same after moving
        /// </summary>
        /// <param name="distance">distance to move</param>
        /// <returns>Point2D</returns>
        public Point2D MoveX(double distance) => MoveX(this, distance);

        /// <summary>
        /// Moves by a distance, parallel to y-axis and also returns a new Point2D object of the same after moving
        /// </summary>
        /// <param name="distance">distance to move</param>
        /// <returns>Point2D</returns>
        public Point2D MoveY(double distance) => MoveY(this, distance);


        /// <summary>
        /// Rotates a specified Point2D object by an angle with respect to an axis and also returns a new Point2D object of the same after moving
        /// </summary>
        /// <param name="point">Point2D object to be rotated</param>
        /// <param name="angle">Rotation angle</param>
        /// <param name="axis">Axis of rotation</param>
        /// <returns>Point2D</returns>
        public static Point2D Rotate(Point2D point, Angle angle, Point2D axis)
        {
            point.X -= axis.X;
            point.Y -= axis.Y;

            double xnew = point.X * Math.Cos(angle.Radian) - point.Y * Math.Sin(angle.Radian);
            double ynew = point.X * Math.Sin(angle.Radian) + point.Y * Math.Cos(angle.Radian);

            point.X = xnew + axis.X;
            point.Y = ynew + axis.Y;

            return point;
        }

        /// <summary>
        /// Rotates by an angle with respect to an axis
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="axis"></param>
        /// <returns></returns>
        public Point2D Rotate(Angle angle, Point2D axis) => Rotate(this, angle, axis);


        /// <summary>
        /// Returns the midpoint of two points
        /// </summary>
        /// <param name="p1">point 1</param>
        /// <param name="p2">point 2</param>
        /// <returns></returns>
        public static Point2D MidPoint(Point2D p1, Point2D p2) => (p1 + p2) / 2;


        /// <summary>
        /// Returns the distance bwtween two points
        /// </summary>
        /// <param name="P1">Point 1</param>
        /// <param name="P2">Point 2</param>
        /// <returns>double</returns>
        public static double DistanceBetween(Point2D P1, Point2D P2) => Math.Sqrt(Math.Pow(P2.X - P1.X, 2) + Math.Pow(P2.Y - P1.Y, 2));

        /// <summary>
        /// Returns the distance between this point and another point
        /// </summary>
        /// <param name="point">Point2D of whose distance is to be measured from</param>
        /// <returns>double</returns>
        public double DistanceFrom(Point2D point) => DistanceBetween(this, point);

        /// <summary>
        /// Returns the angle of inclination of a lineSegment
        /// </summary>
        /// <param name="point1">point 1</param>
        /// <param name="point2">point 2</param>
        /// <returns>Angle</returns>
        public static Angle AngleOfElevation(Point2D point1, Point2D point2) => new Angle(Math.Atan2((point2 - point1).Y, (point2 - point1).X), Angle.Unit.Radians);

        /// <summary>
        /// Returns a string of the form "(x, y)"
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() => "(" + Math.Round(X, 4) + ", " + Math.Round(Y, 4) + ")";


        public static bool IsInBetween(Point2D point, Point2D point1, Point2D point2) => Compare.IsInBetween(point.X, point1.X, point2.X) && Compare.IsInBetween(point.Y, point1.Y, point2.Y);

        public bool IsInBetween(Point2D point1, Point2D point2) => IsInBetween(this, point1, point2);

        public override bool Equals(object obj) => obj.GetType() == GetType() ? ((Point2D)obj == this) : false;

        public override int GetHashCode() => (int)Math.Pow(X, Y);


        /// -------------------------- <<-     A R I T H M E T I C   O P E R A T I O N S   O N   P O I N T     ->> --------------------------


        /// <summary>
        /// returns Point2D(p1.X + p2.X, p1.Y + p2.Y)
        /// </summary>
        /// <param name="p1">point 1</param>
        /// <param name="p2">point 2</param>
        /// <returns>Point2D</returns>
        public static Point2D operator +(Point2D p1, Point2D p2) => new Point2D(p1.X + p2.X, p1.Y + p2.Y);

        /// <summary>
        /// returns Point2D(point.X * factor, point.Y * factor)
        /// </summary>
        /// <param name="point">point</param>
        /// <param name="factor">multiplication factor</param>
        /// <returns>Point2D</returns>
        public static Point2D operator *(Point2D point, double factor) => new Point2D(point.X * factor, point.Y * factor);

        /// <summary>
        /// returns Point2D(point.X * factor, point.Y * factor)
        /// </summary>
        /// <param name="factor">multiplication factor</param>
        /// <param name="point">point</param>
        /// <returns>Point2D</returns>
        public static Point2D operator *(double factor, Point2D point) => point * factor;

        /// <summary>
        /// returns Point2D(point * (1 / factor))
        /// </summary>
        /// <param name="point">point</param>
        /// <param name="factor">division factor</param>
        /// <returns>Point2D</returns>
        public static Point2D operator /(Point2D point, double factor) => new Point2D(point * (1 / factor));

        /// <summary>
        /// returns point * -1
        /// </summary>
        /// <param name="point">point</param>
        /// <returns>Point2D</returns>
        public static Point2D operator -(Point2D point) => point * -1;

        /// <summary>
        /// returns p1 + (-p2)
        /// </summary>
        /// <param name="p1">point 1</param>
        /// <param name="p2">point 2</param>
        /// <returns>Point2D</returns>
        public static Point2D operator -(Point2D p1, Point2D p2) => p1 + (-p2);

        public static bool operator ==(Point2D p1, Point2D p2) => DistanceBetween(p1, p2) == 0;

        public static bool operator !=(Point2D p1, Point2D p2) => !(p1 == p2);

        /// _________________________________________________________________________________________________________________________________
        
    }
}
