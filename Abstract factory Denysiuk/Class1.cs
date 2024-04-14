using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace abstract_factory
{
    public interface IPolygonFactory
    {
        IPolygon CreatePolygon(List<Point> points);
    }

    public interface IPolygon
    {
        double GetArea();
        string GetDescription();
    }

    public class ConvexPolygonFactory : IPolygonFactory
    {
        public IPolygon CreatePolygon(List<Point> points)
        {
            if (IsConvex(points))
            {
                return new ConvexPolygon(points);
            }
            else
            {
                throw new ArgumentException("Точки не утворюють опуклий багатокутник");
            }
        }

        private bool IsConvex(List<Point> points)
        {
            int n = points.Count;

            if (n < 3)
            {
                return true; // Точки, що утворюють лінію або точку, вважаються опуклими
            }

            for (int i = 0; i < n; i++)
            {
                int next = (i + 1) % n;
                int prev = (i - 1 + n) % n;

                Vector2 v1 = new Vector2(points[next].X - points[i].X, points[next].Y - points[i].Y);
                Vector2 v2 = new Vector2(points[prev].X - points[i].X, points[prev].Y - points[i].Y);

                if ((v1.X * v2.Y - v1.Y * v2.X) < 0)
                {
                    return false;
                }
            }

            return true;
        }

    }

    public class NonConvexPolygonFactory : IPolygonFactory
    {
        public IPolygon CreatePolygon(List<Point> points)
        {
            return new NonConvexPolygon(points);
        }
    }

    public class ConvexPolygon : IPolygon
    {
        private List<Point> points;

        public ConvexPolygon(List<Point> points)
        {
            this.points = points;
        }

        public double GetArea()
        {
            double area = 0;
            int n = points.Count;

            for (int i = 0; i < n - 1; i++)
            {
                area += (points[i].X * points[i + 1].Y) - (points[i + 1].X * points[i].Y);
            }

            area += (points[n - 1].X * points[0].Y) - (points[0].X * points[n - 1].Y);

            return Math.Abs(area / 2);
        }

        public string GetDescription()
        {
            return "Опуклий багатокутник з " + points.Count + " вершинами";
        }
    }

    public class NonConvexPolygon : IPolygon
    {
        private List<Point> points;

        public NonConvexPolygon(List<Point> points)
        {
            this.points = points;
        }

        public double GetArea()
        {
            double area = 0;

            for (int i = 0; i < points.Count - 1; i++)
            {
                double x1 = points[i].X;
                double y1 = points[i].Y;
                double x2 = points[i + 1].X;
                double y2 = points[i + 1].Y;

                double baseLength = Math.Abs(x2 - x1);
                double averageHeight = (y1 + y2) / 2;

                area += baseLength * averageHeight;
            }

            return area;
        }


        public string GetDescription()
        {
            return "Неопуклий багатокутник з " + points.Count + " вершинами";
        }
    }


}
