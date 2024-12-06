using System.Collections.Concurrent;

namespace study4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rect = new rectangle();
            rect.InPut();
            Console.WriteLine($" area of rect = " + rect.Area());
            ////////////////////////////////////////////////////
            circle circle1 = new circle();
            circle1.InPut();
            Console.WriteLine($" radius of circle = " + circle1.Area());
            ////////////////////////////////////////////////////          
            square square1 = new square();
            square1.InPut();
            Console.WriteLine($" area of square = " + square1.Area());
            ////////////////////////////////////////////////////  
        }
    }
}
public class rectangle
{
    private int a,b;
    public rectangle()
    {
        a = 0;
        b = 0;
    }
    public rectangle(int a,int b)
    {
        this.a = a;
        this.b = b;
    }
    public void InPut()
    {
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
    }
    public int Area()
    {
        return a * b;
    }
    public void OutPut()
    {
        Console.WriteLine($" side a : {a} side b : {b}");
    }
}
public class circle
{
    private double radius;
    public circle()
    {
        radius = 0;
    }
    public circle(float Radius)
    {
        radius = Radius;
    }
    public void InPut()
    {
        radius = double.Parse(Console.ReadLine());
    }
    public double Area()
    {
        return Math.PI * radius * radius;
    }
    public void OutPut()
    {
        Console.WriteLine($" radius of circle {radius}");
    }
}
public class square
{
    private int a;
    public square()
    {
        a = 0;
    }
    public square(int a)
    {
        this.a = a;
    }
    public void InPut()
    {
        a = int.Parse(Console.ReadLine());
    }
    public int Area()
    {
        return a * a;
    }
    public void OutPut()
    {
        Console.WriteLine($" side of square {a}");
    }
}