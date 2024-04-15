using Lab_6_2_patterns.Interface;

namespace Lab_6_2_patterns.Factory
{
    internal class ConvexPolygonFactory : IFigureFactory
    {
        public IFigure CreateFigure(List<Point> points)
        {
            return new ConvexPolygon(points);
        }
    }
}
