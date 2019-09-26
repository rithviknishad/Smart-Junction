using System.Drawing;

namespace GUI.Simulation.Graphics
{
    public struct Polygon
    {
        public Point[] Vertices;

        public Polygon(Point[] vertices) => Vertices = vertices;
    }
}