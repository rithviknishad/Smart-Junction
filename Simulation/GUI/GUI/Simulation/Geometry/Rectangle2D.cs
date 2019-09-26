using System;

namespace GUI.Simulation.Geometry
{
    public class Rectangle2D
    {
        /// <summary>
        /// Inclination angle of the rectangle (angle between x axis and length axis)
        /// </summary>
        public Angle Inclination { get; private set; }

        /// <summary>
        /// Length measure of the rectangle
        /// </summary>
        public double Length { get; private set; }
        /// <summary>
        /// Breadth measure of the rectangle
        /// </summary>
        public double Breadth { get; private set; }

        /// <summary>
        /// Area of the rectangle
        /// </summary>
        public double Area => Length * Breadth;

        /// <summary>
        /// Perimeter of the rectangle
        /// </summary>
        public double Perimeter => 2 * (Length + Breadth);

        /// <summary>
        /// Midpoint of the rectangle
        /// </summary>
        public Point2D Midpoint { get; private set; }

        /// <summary>
        /// LineSegment => Along the length axis of the rectangle
        /// </summary>
        public LineSegment2D MiddleLength => new LineSegment2D(Midpoint, Length, Inclination);
        /// <summary>
        /// LineSegment => Along the breadth axis of the rectangle
        /// </summary>
        public LineSegment2D MiddleBreadth => new LineSegment2D(Midpoint, Breadth, Inclination + Angle.A90);

        /// <summary>
        /// Midpoint of edge AB
        /// </summary>
        public Point2D OA => MiddleLength.A;
        /// <summary>
        /// Midpoint of edge BC
        /// </summary>
        public Point2D OB => MiddleBreadth.B;
        /// <summary>
        /// Midpoint of edge CD
        /// </summary>
        public Point2D OC => MiddleLength.B;
        /// <summary>
        /// Midpoint of edge AD
        /// </summary>
        public Point2D OD => MiddleBreadth.A;

        /// <summary>
        /// Edge AD
        /// </summary>
        public LineSegment2D AD => new LineSegment2D(OD, Length, Inclination);
        /// <summary>
        /// Edge BC
        /// </summary>
        public LineSegment2D BC => new LineSegment2D(OB, Length, Inclination);

        /// <summary>
        /// Corner A
        /// </summary>
        public Point2D A => AD.A;
        /// <summary>
        /// Corner B
        /// </summary>
        public Point2D B => BC.A;
        /// <summary>
        /// Corner C
        /// </summary>
        public Point2D C => BC.B;
        /// <summary>
        /// Corner D
        /// </summary>
        public Point2D D => AD.B;

        public Point2D[] Vertices => new Point2D[] { A, B, C, D };

        /// <summary>
        /// Edge AB
        /// </summary>
        public LineSegment2D AB => new LineSegment2D(A, B);

        /// <summary>
        /// Edge CD
        /// </summary>
        public LineSegment2D CD => new LineSegment2D(C, D);

        /// <summary>
        /// Diagonal AC
        /// </summary>
        public LineSegment2D AC => new LineSegment2D(A, C);

        /// <summary>
        /// Diagonal BD
        /// </summary>
        public LineSegment2D BD => new LineSegment2D(B, D);


        /// <summary>
        /// Moves the specified rectangle object by a specified distance along a specified angle
        /// </summary>
        /// <param name="rectangle"></param>
        /// <param name="distance">distance to be moved</param>
        /// <param name="angle">angle to be moved</param>
        /// <returns>Rectangle</returns>
        public static Rectangle2D Move(Rectangle2D rectangle, double distance, Angle angle = null) => new Rectangle2D(rectangle.Length, rectangle.Breadth, rectangle.Midpoint.Move(distance, angle ?? Angle.A0), rectangle.Inclination);

        /// <summary>
        /// Moves the current rectangle by a specified distance along a specified angle
        /// </summary>
        /// <param name="distance">distance to be moved</param>
        /// <param name="angle">angle to be moved</param>
        /// <returns>Rectangle</returns>
        public Rectangle2D Move(double distance, Angle angle = null) => Move(this, distance, angle ?? Angle.A0);

        /// <summary>
        /// Rotates a given rectangle by a specific angle along a specified axis point (default (null) value is midpoint of the specified rectangle)
        /// </summary>
        /// <param name="rectangle">Rectangle to be rotated</param>
        /// <param name="angle">Angle of rotation</param>
        /// <param name="axis">Axis of rotation</param>
        /// <returns>Rectangle</returns>
        public static Rectangle2D Rotate(Rectangle2D rectangle, Angle angle, Point2D axis = null) => new Rectangle2D(rectangle.Length, rectangle.Breadth, rectangle.Midpoint = rectangle.Midpoint.Rotate(angle, axis ?? rectangle.Midpoint), rectangle.Inclination += angle);

        /// <summary>
        /// Rotates the rectangle by a specific angle along a specified axis point (default (null) value is midpoint of the specified rectangle)
        /// </summary>
        /// <param name="angle">Angle of rotation</param>
        /// <param name="axis">Axis of rotation</param>
        /// <returns>Rectangle</returns>
        public Rectangle2D Rotate(Angle angle, Point2D axis = null) => Rotate(this, angle, axis ?? Midpoint);


        /// <summary>
        /// Constructs a rectangle object with it's length, breadth, midpoint and inclination angle specified
        /// </summary>
        /// <param name="length">Length of the rectangle</param>
        /// <param name="breadth">Breadth of the rectangle</param>
        /// <param name="midpoint">Midpoint of the rectangle</param>
        /// <param name="inclination">Inclination angle of the rectangle</param>
        public Rectangle2D(double length, double breadth, Point2D midpoint, Angle inclination)
        {
            Length = length;
            Breadth = breadth;
            Midpoint = midpoint;
            Inclination = inclination;
        }

        /// <summary>
        /// Copies a rectangle
        /// </summary>
        /// <param name="rectangle">rectangle to be copied</param>
        public Rectangle2D(Rectangle2D rectangle)
        {
            Length = rectangle.Length;
            Breadth = rectangle.Breadth;
            Midpoint = rectangle.Midpoint;
            Inclination = rectangle.Inclination;
        }

        /// <summary>
        /// Checks whther the point lies inside a given rectangle or not
        /// </summary>
        /// <param name="rectangle">Rectangle</param>
        /// <param name="point">Point</param>
        /// <returns>bool</returns>
        public static bool PointLiesInside(Rectangle2D rectangle, Point2D point) => Math.Round(rectangle.Area, 8) == Math.Round(new Triangle2D(rectangle.A, point, rectangle.B).Area + new Triangle2D(rectangle.B, point, rectangle.C).Area + new Triangle2D(rectangle.C, point, rectangle.D).Area + new Triangle2D(rectangle.D, point, rectangle.A).Area, 8);

        /// <summary>
        /// Checks whether the point lies inside the rectangle or not
        /// </summary>
        /// <param name="point">point</param>
        /// <returns>bool</returns>
        public bool PointLiesInside(Point2D point) => PointLiesInside(this, point);

        public override string ToString() => "[ " + A + " " + B + " " + C + " "  + D + " ]";

        public override bool Equals(object obj) => obj.GetType() == GetType() ? ((Rectangle2D)obj == this) : false;

        public override int GetHashCode() => 0;

        public static bool operator ==(Rectangle2D left, Rectangle2D right) => left.Midpoint == right.Midpoint && left.Inclination == right.Inclination && left.Length == right.Length && left.Breadth == right.Breadth;

        public static bool operator !=(Rectangle2D left, Rectangle2D right) => !(left == right);

    }
}
