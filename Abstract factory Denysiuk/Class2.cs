using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class PointInput
    {
        public static List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();

            Console.WriteLine("Введіть кількість точок:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введіть координати точки " + (i + 1) + " (x, y):");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                points.Add(new Point(x, y));
            }

            return points;
        }
    }
}
