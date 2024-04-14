using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstract_factory;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Виберіть тип фабрики:");
        Console.WriteLine("1. Опуклий багатокутник");
        Console.WriteLine("2. Неопуклий багатокутник");

        int choice = int.Parse(Console.ReadLine());

        IPolygonFactory factory;
        if (choice == 1)
        {
            factory = new ConvexPolygonFactory();
        }
        else if (choice == 2)
        {
            factory = new NonConvexPolygonFactory();
        }
        else
        {
            Console.WriteLine("Неправильний вибір.");
            return;
        }

        List<Point> points = PointInput.GetPoints();

        IPolygon polygon = factory.CreatePolygon(points);

        Console.WriteLine(polygon.GetDescription());
        Console.WriteLine("Площа: " + polygon.GetArea());
    }
}
