using Lab_6_2_patterns.Interface;

namespace Lab_6_2_patterns
{
    public class NonСonvexPolygon : IFigure
    {
        private List<Point> _points;

        public NonСonvexPolygon(List<Point> points)
        {
            _points = points;
        }

        public bool CreatePolygon()
        {
            if (!IsConvex(_points))
            {
                Console.WriteLine("Створено неопуклий полігон");
                return true;
            }
            else
            {
                Console.WriteLine("Неможливо створити неопуклий многокутник: точки вводу утворюють опуклий многокутник");
                return false;
            }
        }

        private bool IsConvex(List<Point> points)
        {
            int n = points.Count;
            if (n < 3)
                return false;

            bool sign = false;
            for (int i = 0; i < n; i++)
            {
                int dx1 = points[(i + 2) % n].X - points[(i + 1) % n].X;
                int dy1 = points[(i + 2) % n].Y - points[(i + 1) % n].Y;
                int dx2 = points[i].X - points[(i + 1) % n].X;
                int dy2 = points[i].Y - points[(i + 1) % n].Y;
                int crossProduct = dx1 * dy2 - dy1 * dx2;

                if (i == 0)
                    sign = crossProduct > 0;
                else if (crossProduct > 0 != sign)
                    return false;
            }
            return true;
        }
    }
}

