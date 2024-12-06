using System.Xml.Linq;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Ifigure square1 = square;
            square1.InPut();
            square1.OutPut();
            Console.WriteLine($"result = " + square1.Area());

            Circle circle = new Circle();
            Ifigure circle1 = circle;
            circle1.InPut();
            circle1.OutPut();
            Console.WriteLine($"result = " + circle1.Area());

            Rhombus rhomb=new Rhombus();
            Ifigure rhombus1 = rhomb;
            rhombus1.InPut();
            rhombus1.OutPut();
            Console.WriteLine($"result = " + rhombus1.Area());

            Rectangle rectangle = new Rectangle();
            Ifigure rectangle1 = rectangle;
            rectangle1.InPut();
            rectangle1.OutPut();
            Console.WriteLine($"result = " + rectangle1.Area()); 
        }
    }

}
interface Ifigure
{
    void InPut();
    void OutPut();
    double Area();
}
public class Square:Ifigure
{
    private double a;
    void Ifigure.InPut()
    {
        a = double.Parse(Console.ReadLine());
    }
    void Ifigure.OutPut()
    {
        Console.WriteLine($"a {a}");
    }
    double Ifigure.Area()
    {
        return a * a;
    }
}
public class Circle:Ifigure
{
    private double radius;
    void Ifigure.InPut()
    {
        radius = double.Parse(Console.ReadLine());
    }
    void Ifigure.OutPut()
    {
        Console.WriteLine($" radius {radius}");
    }
    double Ifigure.Area()
    {
        return Math.PI * radius * radius;
    }
}
public class Rhombus:Ifigure
{
    private double a,h;
    void Ifigure.InPut()
    {
        a = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());
    }
    void Ifigure.OutPut()
    {
        Console.WriteLine($"a {a} h {h}");
    }
    double Ifigure.Area()
    {
        return a * h;
    }
}
public class Rectangle:Ifigure
{
    private double a;
    void Ifigure.InPut()
    {
        a = double.Parse(Console.ReadLine());
    }
    void Ifigure.OutPut()
    {
        Console.WriteLine($"a {a}");
    }
    double Ifigure.Area()
    {
        return a * a;
    }
}