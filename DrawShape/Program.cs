using DrawShape;
using DrawShape.Shapes;

var list = new List<IShape>();

var circle = new Circle(2);
var square = new Square(4);
var triangle = new Triangle(3, 4, 5);
var rectangle = new Rectangle(6, 8);

list.AddRange(new IShape[] { circle, square, triangle, rectangle });

foreach (var shape in list)
{
    ShowParameters(shape);
    DrawFigure(shape);
}

Console.ReadLine();


void DrawFigure(IShape figure)
{
    Console.WriteLine(figure.Draw());
}
void ShowParameters(IShape shape)
{
    Console.WriteLine($"Фигура: {shape.GetName()}, Площадь = {shape.GetArea()}, Периметр = {shape.GetPerimeter()}");
}