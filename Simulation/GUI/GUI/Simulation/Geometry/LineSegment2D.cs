using System;

using GUI.Mathematical_Tools;

namespace GUI.Simulation.Geometry
{
    public class LineSegment2D
    {

        /// <summary>
        /// End point of the line
        /// </summary>
        public Point2D A, B;
        public Line2D Line => new Line2D(A, B);

        /// <summary>
        /// Returns the midpoint of this line segment
        /// </summary>
        public Point2D Midpoint => MidPoint(this); // add set property!!

        /// <summary>
        /// gets and sets the angle of inclination of this line segment
        /// </summary>
        public Angle Inclination
        {
            get => AngleOfInclination();
            set => Rotate(value - Inclination);
        }

        /// <summary>
        /// Generates this LineSegment object with it's two endpoints specified
        /// </summary>
        /// <param name="a">end point 1</param>
        /// <param name="b">end point 2</param>
        public LineSegment2D(Point2D a, Point2D b)
        {
            A = a;
            B = b;
        }

        /// <summary>
        /// Copies the specified lineSegment
        /// </summary>
        /// <param name="lineSegment">LineSegment object to be copied</param>
        public LineSegment2D(LineSegment2D lineSegment)
        {
            A = lineSegment.A;
            B = lineSegment.B;
        }

        /// <summary>
        /// Generates this LineSegment object with it's midpoint, lenght, and inclination angle specified
        /// </summary>
        /// <param name="midpoint">midpoint of the line</param>
        /// <param name="length">length of the line</param>
        /// <param name="inclination">inclination angle of the line</param>
        public LineSegment2D(Point2D midpoint, double length, Angle inclination)
        {
            A = new Point2D(midpoint).Move(length / 2, inclination);
            B = new Point2D(midpoint).Move(length / 2, inclination + new Angle(180, Angle.Unit.Degrees));
        }


        /// <summary>
        /// Moves a specified lineSegment by a distance through an angle
        /// </summary>
        /// <param name="lineSegment"></param>
        /// <param name="distance"></param>
        /// <param name="angle"></param>
        /// <returns>LineSegment</returns>
        public static LineSegment2D Move(LineSegment2D lineSegment, double distance, Angle angle) => new LineSegment2D(lineSegment.A = lineSegment.A.Move(distance, angle), lineSegment.B = lineSegment.B.Move(distance, angle));

        /// <summary>
        /// Moves this lineSegment by a distance through an angle
        /// </summary>
        /// <param name="distance">distance to move</param>
        /// <param name="angle">angle of movement wrt to origin</param>
        /// <returns>LineSegment</returns>
        public LineSegment2D Move(double distance, Angle angle = null) => Move(this, distance, angle: (angle ?? Inclination));

        /// <summary>
        /// Moves this lineSegment by a specified distance in a direction of angle with respect to it's current angle of inclination
        /// </summary>
        /// <param name="distance">distance to moved</param>
        /// <param name="direction">direction to move</param>
        /// <returns>LineSegment</returns>
        public LineSegment2D Move(double distance, Directions direction)
        {
            if (direction == Directions.Forward)
                return Move(distance, Inclination);
            else if (direction == Directions.Left)
                return Move(distance, Inclination + new Angle(90, Angle.Unit.Degrees));
            else if (direction == Directions.Right)
                return Move(distance, Inclination - new Angle(90, Angle.Unit.Degrees));
            else if (direction == Directions.Backward)
                return Move(distance, Inclination + new Angle(180, Angle.Unit.Degrees));

            return this;
        }

        public static LineSegment2D Shrink(LineSegment2D lineSegment, double value) => new LineSegment2D(lineSegment.A = lineSegment.A.Move(value, lineSegment.Inclination - Angle.A180), lineSegment.B = lineSegment.B.Move(value, lineSegment.Inclination));

        public LineSegment2D Shirnk(double value) => Shrink(this, value);


        /// <summary>
        /// Rotates a lineSegment by an angle through an axis.
        /// </summary>
        /// <param name="lineSegment">lineSegment (obj) to rotate</param>
        /// <param name="angle">angle to be rotated</param>
        /// <param name="axis">axis of rotation (deault is midpoint of given lineSegment)</param>
        /// <returns>LineSegment</returns>
        public static LineSegment2D Rotate(LineSegment2D lineSegment, Angle angle, Point2D axis) => new LineSegment2D(lineSegment.A = lineSegment.A.Rotate(angle, axis), lineSegment.B = lineSegment.B.Rotate(angle, axis));

        /// <summary>
        /// Rotates the lineSegment by an angle through an axis
        /// </summary>
        /// <param name="angle">angle to be rotated</param>
        /// <param name="axis">axis of rotation (deault is midpoint of given lineSegment)</param>
        /// <returns>LineSegment</returns>
        public LineSegment2D Rotate(Angle angle, Point2D axis = null) => Rotate(this, angle, axis ?? Midpoint);


        /// <summary>
        /// Returns the midpoint of specified lineSegment
        /// </summary>
        /// <param name="lineSegment">whose midpoint to be found</param>
        /// <returns>Point2D</returns>
        public static Point2D MidPoint(LineSegment2D lineSegment) => Point2D.MidPoint(lineSegment.A, lineSegment.B);


        /// <summary>
        /// Returns the length of specified lineSegment
        /// </summary>
        /// <param name="lineSegment">whose length to be found</param>
        /// <returns>double"</returns>
        public static double Length(LineSegment2D lineSegment) => Point2D.DistanceBetween(lineSegment.A, lineSegment.B);
        /// <summary>
        /// Returns the length of the lineSegment
        /// </summary>
        /// <returns>double</returns>
        public double Length() => Length(this);


        /// <summary>
        /// Returns the angle of inclination of a lineSegment
        /// </summary>
        /// <param name="lineSegment">Line whose inclination angle is to be returned</param>
        /// <returns>Angle</returns>
        public static Angle AngleOfInclination(LineSegment2D lineSegment) => Point2D.AngleOfElevation(lineSegment.A, lineSegment.B);

        /// <summary>
        /// Returns the angle of inclination of this lineSegment
        /// </summary>
        /// <returns>Angle</returns>
        public Angle AngleOfInclination() => AngleOfInclination(this);

        public static bool PointLiesOnLineSegment(LineSegment2D lineSegment, Point2D point) => point.IsInBetween(lineSegment.A, lineSegment.B) && lineSegment.Line.PointLiesOnLine(point);

        public override bool Equals(object obj) => obj.GetType() == GetType() ? ((LineSegment2D)obj == this) : false;

        public override int GetHashCode() => (int)Math.Pow(A.GetHashCode(), B.GetHashCode());

        public static bool operator ==(LineSegment2D lineSegment1, LineSegment2D lineSegment2) => ((lineSegment1.A == lineSegment2.A) && (lineSegment1.B == lineSegment2.B)) || ((lineSegment1.A == lineSegment2.B) && (lineSegment1.B == lineSegment2.A));

        public static bool operator !=(LineSegment2D lineSegment1, LineSegment2D lineSegment2) => !(lineSegment1 == lineSegment2);

        public override string ToString() => "[ " + A + " " + B + " ]";
    }
}
