using Lab_6_2_patterns;
using Lab_6_2_patterns.Factory;

var convexFactory = new ConvexPolygonFactory();
var concaveFactory = new NonConvexPolygonFactory();

var convexPoints = new List<Point> { new Point(0, 0), new Point(0, 4), new Point(3, 4), new Point(3, 0) };
var convexPolygon = convexFactory.CreateFigure(convexPoints);
Console.WriteLine("Convex Polygon Created: " + convexPolygon.CreatePolygon());

var concavePoints = new List<Point> { new Point(0, 0), new Point(0, 4), new Point(3, 3), new Point(3, 0) };
var concavePolygon = concaveFactory.CreateFigure(concavePoints);
Console.WriteLine("Concave Polygon Created: " + concavePolygon.CreatePolygon());
