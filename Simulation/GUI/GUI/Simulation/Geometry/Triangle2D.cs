using System;

namespace GUI.Simulation.Geometry
{
    public class Triangle2D
    {

        public Point2D A { get; private set; }
        public Point2D B { get; private set; }
        public Point2D C { get; private set; }

        public LineSegment2D AB => new LineSegment2D(A, B);
        public LineSegment2D BC => new LineSegment2D(B, C);
        public LineSegment2D CA => new LineSegment2D(C, A);

        public Angle Angle_ABC => Line2D.AngleBetween(AB.Line, BC.Line);
        public Angle Angle_BCA => Line2D.AngleBetween(BC.Line, CA.Line);
        public Angle Angle_CAB => Line2D.AngleBetween(CA.Line, AB.Line);

        public Point2D Centroid => (A + B + C) / 3;

        public double Perimeter => AB.Length() + BC.Length() + CA.Length();

        public double Area
        {
            get
            {
                double s = (Perimeter / 2);
                return Math.Sqrt(s * (s - AB.Length()) * (s - BC.Length()) * (s - CA.Length()));
            }
        }

        public Triangle2D(Point2D a, Point2D b, Point2D c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string ToString() => "[ " + A + " " + B + " " + C + " ]";

    }
}
