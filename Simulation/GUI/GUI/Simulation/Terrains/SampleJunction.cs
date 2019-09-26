using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using GUI.Simulation.Geometry;

namespace GUI.Simulation.Terrains
{
    public static class SampleJunction
    { 
        public static readonly ushort RoadLength = 500;
        public static readonly ushort LaneWidth = 5;

        public static readonly Rectangle2D Junction_BOX = new Rectangle2D(20,20, new Point2D(0, 0), Angle.A0);
        public static readonly double InJunctionSpeed = 22; /// in metres per second and NOT metres per FRAME


        public static class SOUTH
        {
            public static class Exit
            {
                public static readonly Angle Heading = Angle.A0;
                public static readonly Rectangle2D LaneL = new Rectangle2D(RoadLength, LaneWidth, new Point2D(260, 7.5), Heading);
                public static readonly Rectangle2D LaneR = new Rectangle2D(RoadLength, LaneWidth, new Point2D(260, 2.5), Heading);
                public static readonly Rectangle2D RoadBound = new Rectangle2D(RoadLength, LaneWidth * 2, new Point2D(260, 5), Heading);
            }
            public static class Entry
            {
                public static readonly Angle Heading = Angle.A180;
                public static readonly Rectangle2D LaneL = new Rectangle2D(RoadLength, LaneWidth, new Point2D(260, -7.5), Heading);
                public static readonly Rectangle2D LaneR = new Rectangle2D(RoadLength, LaneWidth, new Point2D(260, -2.5), Heading);
                public static readonly Rectangle2D RoadBound = new Rectangle2D(RoadLength, LaneWidth * 2, new Point2D(260, -5), Heading);
            }
            public static readonly Rectangle2D OverallBound = new Rectangle2D(RoadLength, LaneWidth * 4, new Point2D(260, 0), Entry.Heading);
        }

        public static class NORTH
        {
            public static class Exit
            {
                public static readonly Angle Heading = Angle.A180;
                public static readonly Rectangle2D LaneL = new Rectangle2D(RoadLength, LaneWidth, new Point2D(-260, -7.5), Heading);
                public static readonly Rectangle2D LaneR = new Rectangle2D(RoadLength, LaneWidth, new Point2D(-260, -2.5), Heading);
                public static readonly Rectangle2D RoadBound = new Rectangle2D(RoadLength, LaneWidth * 2, new Point2D(-260, -5), Heading);
            }
            public static class Entry
            {
                public static readonly Angle Heading = Angle.A0;
                public static readonly Rectangle2D LaneL = new Rectangle2D(RoadLength, LaneWidth, new Point2D(-260, 7.5), Heading);
                public static readonly Rectangle2D LaneR = new Rectangle2D(RoadLength, LaneWidth, new Point2D(-260, 2.5), Heading);
                public static readonly Rectangle2D RoadBound = new Rectangle2D(RoadLength, LaneWidth * 2, new Point2D(-260, 5), Heading);
            }
            public static readonly Rectangle2D OverallBound = new Rectangle2D(RoadLength, LaneWidth * 4, new Point2D(-260, 0), Entry.Heading);
        }

        public static class EAST
        {
            public static class Exit
            {
                public static readonly Angle Heading = Angle.A90;
                public static readonly Rectangle2D LaneL = new Rectangle2D(RoadLength, LaneWidth, new Point2D(-7.5, 260), Heading);
                public static readonly Rectangle2D LaneR = new Rectangle2D(RoadLength, LaneWidth, new Point2D(-2.5, 260), Heading);
                public static readonly Rectangle2D RoadBound = new Rectangle2D(RoadLength, LaneWidth * 2, new Point2D(-5, 260), Heading);
            }
            public static class Entry
            {
                public static readonly Angle Heading = Angle.A270;
                public static readonly Rectangle2D LaneL = new Rectangle2D(RoadLength, LaneWidth, new Point2D(7.5, 260), Heading);
                public static readonly Rectangle2D LaneR = new Rectangle2D(RoadLength, LaneWidth, new Point2D(2.5, 260), Heading);
                public static readonly Rectangle2D RoadBound = new Rectangle2D(RoadLength, LaneWidth * 2, new Point2D(5, 260), Heading);
            }
            public static readonly Rectangle2D OverallBound = new Rectangle2D(RoadLength, LaneWidth * 4, new Point2D(0, 260), Entry.Heading);
        }

        public static class WEST
        {
            public static class Exit
            {
                public static readonly Angle Heading = Angle.A270;
                public static readonly Rectangle2D LaneL = new Rectangle2D(RoadLength, LaneWidth, new Point2D(7.5, -260), Heading);
                public static readonly Rectangle2D LaneR = new Rectangle2D(RoadLength, LaneWidth, new Point2D(2.5, -260), Heading);
                public static readonly Rectangle2D RoadBound = new Rectangle2D(RoadLength, LaneWidth * 2, new Point2D(5, -260), Heading);
            }
            public static class Entry
            {
                public static readonly Angle Heading = Angle.A90;
                public static readonly Rectangle2D LaneL = new Rectangle2D(RoadLength, LaneWidth, new Point2D(-7.5, -260), Heading);
                public static readonly Rectangle2D LaneR = new Rectangle2D(RoadLength, LaneWidth, new Point2D(-2.5, -260), Heading);
                public static readonly Rectangle2D RoadBound = new Rectangle2D(RoadLength, LaneWidth * 2, new Point2D(-5, -260), Heading);
            }
            public static readonly Rectangle2D OverallBound = new Rectangle2D(RoadLength, LaneWidth * 4, new Point2D(0, -260), Entry.Heading);
        }

        public static Rectangle2D[] EntryBounds
            => new Rectangle2D[]
            {
                NORTH.Entry.RoadBound,
                SOUTH.Entry.RoadBound,
                EAST.Entry.RoadBound,
                WEST.Entry.RoadBound
            };

        public static Rectangle2D[] ExitBounds
            => new Rectangle2D[]
            {
                NORTH.Exit.RoadBound,
                SOUTH.Exit.RoadBound,
                EAST.Exit.RoadBound,
                WEST.Exit.RoadBound
            };

        public static Rectangle2D[] AllLaneBounds 
            => new Rectangle2D[]  
            {
                NORTH.Entry.LaneL, NORTH.Entry.LaneR, NORTH.Exit.LaneL, NORTH.Exit.LaneR,
                SOUTH.Entry.LaneL, SOUTH.Entry.LaneR, SOUTH.Exit.LaneL, SOUTH.Exit.LaneR,
                EAST.Entry.LaneL, EAST.Entry.LaneR, EAST.Exit.LaneL, EAST.Exit.LaneR,
                WEST.Entry.LaneL, WEST.Entry.LaneR, WEST.Exit.LaneL, WEST.Exit.LaneR
            };

        public static Rectangle2D[] AllRoadBounds
            => new Rectangle2D[]
            {
                NORTH.Entry.RoadBound, NORTH.Exit.RoadBound,
                SOUTH.Entry.RoadBound, SOUTH.Exit.RoadBound,
                EAST.Entry.RoadBound, EAST.Exit.RoadBound,
                WEST.Entry.RoadBound, WEST.Exit.RoadBound
            };

        public static Rectangle2D[] AllChannelBound
            => new Rectangle2D[]
            {
                NORTH.OverallBound,
                SOUTH.OverallBound,
                EAST.OverallBound,
                WEST.OverallBound
            };
    }
}
