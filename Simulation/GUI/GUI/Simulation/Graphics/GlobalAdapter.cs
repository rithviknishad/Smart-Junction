using System.Collections.Generic;

using GUI.Simulation.Geometry;

namespace GUI.Simulation.Graphics
{
    public static class GlobalAdapter
    {

        public static Polygon TransformToPolygon(Rectangle2D rectangle) => new Polygon(PointMapper.TranslateToSystemPoint(rectangle.Vertices));

        public static Polygon[] TransformToPolygon(Rectangle2D[] rectangles)
        {
            List<Polygon> buffer = new List<Polygon>();

            foreach (Rectangle2D rectangle in rectangles)
            {
                buffer.Add(TransformToPolygon(rectangle));
            }

            return buffer.ToArray();
        }

    }
}
