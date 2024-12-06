namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Izvikvane na metodi s neqvna implementaciq:
            //////////////////////////////////////////////////
            Square sq = new Square();
            sq.Input();
            sq.Output();
            Console.WriteLine($"result={sq.Area()}");

            circle cr = new circle();
            cr.Input();
            cr.Output();
            Console.WriteLine($"result= {cr.Area()}");

            Rhombus rhomb = new Rhombus();
            rhomb.Input();
            rhomb.Output();
            Console.WriteLine($"result= {rhomb.Area()}");
            //////////////////////////////////////////////////
            // Izvikvane na metodi s qavna implementaciq:

            Rectangle rec = new Rectangle();
            IFigure rec1 = rec;
            rec1.Input();
            rec1.Output();
            Console.WriteLine($"result= {rec1.Area()}");

            Triangle tri = new Triangle();
            IFigure tri1 = tri;
            tri1.Input();
            tri1.Output();
            Console.WriteLine($"result= {tri1.Area()}");

        }
    }
}
interface IFigure
{
    public void Input();
    public void Output();
    public double Area();
}
class Square : IFigure
{
    private double a;
    private double b;
    public void Input()// neqvna implementaciq
    {
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
    }
    public void Output()// neqvna implementaciq
    {
        Console.WriteLine($"a={a} | b= {b}");
    }
    public double Area()// neqvna implementaciq
    {
        return a * b;
    }
}
class circle : IFigure
{
    private double r;
    public void Input()// neqvna implementaciq
    {
        r = double.Parse(Console.ReadLine());
    }
    public void Output()// neqvna implementaciq
    {
        Console.WriteLine($"r={r}");
    }
    public double Area()// neqvna implementaciq
    {
        return Math.PI * Math.Pow(r, 2);
    }
}
class Rhombus : IFigure
{
    private double a;
    private double h;
    public void Input() // neqvna implementaciq
    {
        a = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());
    }
    public void Output()// neqvna implementaciq
    {
        Console.WriteLine($"a={a} | h={h}");
    }
    public double Area()// neqvna implementaciq
    {
        return a * h;
    }
}
class Rectangle : IFigure
{
    private double a;
    private double b;
    void IFigure.Input() //qavna implementaciq
    {
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
    }
    void IFigure.Output() //qavna implementaciq
    {
        Console.WriteLine($"a={a} | b={b}");
    }
    double IFigure.Area() //qavna implementaciq
    {
        return a * b;
    }
}
class Triangle : IFigure
{
    private double a;
    private double b;
    private double c;
    void IFigure.Input()//qavna implementaciq
    {
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
    }
    void IFigure.Output()//qavna implementaciq
    {
        Console.WriteLine($"a={a} | b={b} | c={c}");
    }
    double IFigure.Area()//qavna implementaciq
    {
        return (a + b + c) / 2;
    }
}