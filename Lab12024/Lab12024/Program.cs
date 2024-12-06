using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] Shapes = {new Rectangle(2, 3), new Triangle(4, 5, 6), new Circle(7)};

            double [] Areas = new double[Shapes.Length];
            for(int i =0; i < Shapes.Length; i++)
            {
                Areas[i] = Shapes[i].CalculateArea();
            }
            foreach(double area in Areas)
            {
                Console.WriteLine($"area {area}");
            }

           
        }
    }
}
public abstract class Shape 
{
    public abstract double CalculateArea();
}
public class Rectangle : Shape
{
    private double a, b;
    public Rectangle(double a, double b)
    {
        this.a = a;
        this.b = b;
    }
    public override double CalculateArea()
    {
        return a * b;
    }
}
public class Triangle : Shape
{
    private double a, b, c;
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override double CalculateArea()
    {
        return a + b + c / 2;
    }
}
public class Circle : Shape
{
    private double r;
    public Circle(double r)
    {
        this.r = r;
    }
    public override double CalculateArea()
    {
        return Math.PI * r * r;
    }
}
