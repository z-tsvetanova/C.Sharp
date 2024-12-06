using System;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace abstractclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure fig1;
            fig1 = new Square();
            fig1.InPut();
            fig1.OutPut();
            Console.WriteLine($" area of square = " + fig1.Area());

            Figure fig2;
            fig2 = new Circle();
            fig2.InPut();
            fig2.OutPut();
            Console.WriteLine($"area of circle = " + fig2.Area());

            Figure fig3;
            fig3 = new Rhombus();
            fig3.InPut();
            fig3.OutPut();
            Console.WriteLine($"area of rhombus= " + fig3.Area());

            Figure fig4;
            fig4 = new Rectangle();
            fig4.InPut();
            fig4.OutPut();
            Console.WriteLine($"area of rectangle = " + fig4.Area());

        }
    }
}
abstract public class Figure
{
    public abstract void InPut();
    public abstract void OutPut();
    public abstract double Area();
}
public class Square:Figure
{
    private double a;
    public override void InPut()
    {
        a = double.Parse(Console.ReadLine());
    }
    public override void OutPut()
    {
        Console.WriteLine($" a {a}");
    }
    public override double Area()
    {
        return a * a;
    }
}
public class Circle:Figure
{
    private double radius;
    public override void InPut()
    {
        radius = double.Parse(Console.ReadLine());
    }
    public override void OutPut()
    {
        Console.WriteLine($" radius={radius}");
    }
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}
public class Rhombus:Figure
{
    private double a,h;
    public override void InPut()
    {
        a = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());
    }
    public override void OutPut()
    {
        Console.WriteLine($" a {a} h {h}");
    }
    public override double Area()
    {
        return a * h;
    }
}
public class Rectangle:Figure
{
    private double a;
    public override void InPut()
    {
        a = double.Parse(Console.ReadLine());
    }
    public override void OutPut()
    {
        Console.WriteLine($" a {a}");
    }
    public override double Area()
    {
        return a * a;
    }
}


