using Simulation.Geometry;

namespace Simulation.Terrains
{
    /// <summary>
    /// static terrian / map configuration data
    /// </summary>
    public static class Junction_SCRATCH
    {
        public static readonly ushort RdLn = 490;
        public static readonly Angle A0 = new Angle(0, Angle.Unit.Degrees);
        public static readonly Angle A90 = new Angle(90, Angle.Unit.Degrees);
        public static readonly Angle A180 = new Angle(180, Angle.Unit.Degrees);

        public static readonly Point2D A = new Point2D(-10, 10);
        public static readonly Point2D B = new Point2D(10, 10);
        public static readonly Point2D C = new Point2D(10, -10);
        public static readonly Point2D D = new Point2D(-10, -10);
        public static readonly Point2D AB = Point2D.MidPoint(A, B);
        public static readonly Point2D BC = Point2D.MidPoint(B, C);
        public static readonly Point2D CD = Point2D.MidPoint(C, D);
        public static readonly Point2D DA = Point2D.MidPoint(D, A);
        public static readonly Point2D AAB = Point2D.MidPoint(A, AB);
        public static readonly Point2D ABB = Point2D.MidPoint(B, AB);
        public static readonly Point2D BBC = Point2D.MidPoint(B, BC);
        public static readonly Point2D BCC = Point2D.MidPoint(C, BC);
        public static readonly Point2D CCD = Point2D.MidPoint(C, CD);
        public static readonly Point2D CDD = Point2D.MidPoint(D, CD);
        public static readonly Point2D DDA = Point2D.MidPoint(D, DA);
        public static readonly Point2D DAA = Point2D.MidPoint(A, DA);

        public static readonly Point2D EX = new Point2D(A).Move(RdLn, A90);
        public static readonly Point2D EE = new Point2D(B).Move(RdLn, A90);
        public static readonly Point2D SX = new Point2D(B).Move(RdLn, A0);
        public static readonly Point2D SE = new Point2D(C).Move(RdLn, A0);
        public static readonly Point2D WX = new Point2D(C).Move(RdLn, -A90);
        public static readonly Point2D WE = new Point2D(D).Move(RdLn, -A90);
        public static readonly Point2D NX = new Point2D(D).Move(RdLn, A180);
        public static readonly Point2D NE = new Point2D(A).Move(RdLn, A180);
        public static readonly Point2D EEX = Point2D.MidPoint(EX, EE);
        public static readonly Point2D SEX = Point2D.MidPoint(SX, SE);
        public static readonly Point2D WEX = Point2D.MidPoint(WX, WE);
        public static readonly Point2D NEX = Point2D.MidPoint(NX, NE);
        public static readonly Point2D EEXX = Point2D.MidPoint(EX, EEX);
        public static readonly Point2D EEEX = Point2D.MidPoint(EE, EEX);
        public static readonly Point2D SEXX = Point2D.MidPoint(SX, SEX);
        public static readonly Point2D SEEX = Point2D.MidPoint(SE, SEX);
        public static readonly Point2D WEXX = Point2D.MidPoint(WX, WEX);
        public static readonly Point2D WEEX = Point2D.MidPoint(WE, WEX);
        public static readonly Point2D NEXX = Point2D.MidPoint(NX, NEX);
        public static readonly Point2D NEEX = Point2D.MidPoint(NE, NEX);


        public static readonly Rectangle Junction_BOX = new Rectangle(new LineSegment(A, C), A90);

        public static class NH66_SOUTH
        {
            public static class Exit
            {
                public static readonly Angle Heading = A0;
                public static readonly Rectangle LaneL = new Rectangle(new LineSegment(SX, BBC), Heading);
                public static readonly Rectangle LaneR = new Rectangle(new LineSegment(SEXX, BC), Heading);
            }
            public static class Entry
            {
                public static readonly Angle Heading = A180;
                public static readonly Rectangle LaneL = new Rectangle(new LineSegment(C, SEEX), Heading);
                public static readonly Rectangle LaneR  = new Rectangle(new LineSegment(BCC, SEX), Heading);
            }
        }

        public static class NH66_NORTH
        {
            public static class Exit
            {
                public static readonly Angle Heading = A180;
                public static readonly Rectangle LaneL = new Rectangle(new LineSegment(NX, DDA), Heading);
                public static readonly Rectangle LaneR = new Rectangle(new LineSegment(NEXX, DA), Heading);
            }
            public static class Entry
            {
                public static readonly Angle Heading = A0;
                public static readonly Rectangle LaneL = new Rectangle(new LineSegment(A, NEEX), Heading);
                public static readonly Rectangle LaneR = new Rectangle(new LineSegment(DAA, NEX), Heading);
            }
        }

        public static class THANA_KAKKAD_RD_EAST
        {
            public static class Exit
            {
                public static readonly Angle Heading = A90;
                public static readonly Rectangle LaneL = new Rectangle(new LineSegment(EX, AAB), Heading);
                public static readonly Rectangle LaneR = new Rectangle(new LineSegment(EEXX, AB), Heading);
            }
            public static class Entry
            {
                public static readonly Angle Heading = -A90;
                public static readonly Rectangle LaneL = new Rectangle(new LineSegment(B, EEEX), Heading);
                public static readonly Rectangle LaneR = new Rectangle(new LineSegment(ABB, EEX), Heading);
            }
        }

        public static class THANA_ANAYIDUKKU_RD_WEST
        {
            public static class Exit
            {
                public static readonly Angle Heading = -A90;
                public static readonly Rectangle LaneL = new Rectangle(new LineSegment(WX, CCD), Heading);
                public static readonly Rectangle LaneR = new Rectangle(new LineSegment(WEXX, CD), Heading);
            }
            public static class Entry
            {
                public static readonly Angle Heading = A90;
                public static readonly Rectangle LaneL = new Rectangle(new LineSegment(D, WEEX), Heading);
                public static readonly Rectangle LaneR = new Rectangle(new LineSegment(CDD, WEX), Heading);
            }
        }
    }
}