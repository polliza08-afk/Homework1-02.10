using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapes;

public class Triangle : Shape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        Name = "Трикутник";
        A = a;
        B = b;
        C = c;
    }

    public override double GetArea()
    {
        //Напівпериметр
        double p = (A + B + C) / 2.0;
        //Формула Герона
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
