using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapes;


public abstract class Shape
{
    public string Name { get; protected set; } = "Невідома фігура";

    //Абстрактний метод, який обов'язково має бути перевизначений у дочірніх класах
    public abstract double GetArea();

    public virtual void ViewInfo()
    {
        Console.WriteLine($"Фігура: {Name}");
        Console.WriteLine($"Площа: {GetArea():F2}");
    }
}
