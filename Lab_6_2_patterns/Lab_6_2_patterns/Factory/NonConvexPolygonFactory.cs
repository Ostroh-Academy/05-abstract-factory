using Lab_6_2_patterns.Interface;

namespace Lab_6_2_patterns.Factory
{
    public class NonConvexPolygonFactory : IFigureFactory
    {
        public IFigure CreateFigure(List<Point> points)
        {
            return new NonСonvexPolygon(points);
        }
    }
}
