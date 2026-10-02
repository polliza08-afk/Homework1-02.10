// See https://aka.ms/new-console-template for more information
using System.Text;
using MyShapes;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Абстрактний клас Shape та його нащадки --\n");

//Створюємо масив базового типу Shape,
//що містить об'єкти дочірніх класів
Shape[] shapes = new Shape[]
{
    new Circle(5),
    new Rectangle(4, 6),
    new Triangle(3, 4, 5)
};

foreach (var shape in shapes)
{
    shape.ViewInfo();

    //Визначення конкретного типу об'єкта за допомогою оператора is
    if (shape is Circle circle)
    {
        Console.WriteLine($"Цей коло з радіусом: {circle.Radius}");
    }
    else if (shape is Rectangle rectangle)
    {
        Console.WriteLine($"Цей прямокутник зі сторонами: {rectangle.Width} x {rectangle.Height}");
    }
    else if (shape is Triangle triangle)
    {
        Console.WriteLine($"Цей трикутник зі сторонами: {triangle.A}, {triangle.B}, {triangle.C}");
    }

    Console.WriteLine(new string('-', 35));
}
