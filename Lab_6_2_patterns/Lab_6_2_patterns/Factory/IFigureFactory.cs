using Lab_6_2_patterns.Interface;

namespace Lab_6_2_patterns.Factory
{
    public interface IFigureFactory
    {
        IFigure CreateFigure(List<Point> points);
    }
}
