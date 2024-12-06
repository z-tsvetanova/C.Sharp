namespace LAB11_I_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Figura Kvadrat
            Figure fig1;// Suzdavame obekt ot abstrakten klas
            fig1 = new Square();
            fig1.Input();
            fig1.Output();
            Console.WriteLine($"Result={fig1.Area()}");

            Figure fig2; // Figura Krug
            fig2 = new circle();
            fig2.Input();
            fig2.Output();
            Console.WriteLine($"Result={fig2.Area()}");

            Figure fig3;// Figura Rhomb
            fig3 = new Rhombus();
            fig3.Input();
            fig3.Output();
            Console.WriteLine($"Result={fig3.Area()}");

            Figure fig4;// Figura Pravougulnik
            fig4 = new Rectangle();
            fig4.Input();
            fig4.Output();
            Console.WriteLine($"Result={fig4.Area()}");

            Figure fig5;// Figura Triugulnik
            fig5 = new Triangle();
            fig5.Input();
            fig5.Output();
            Console.WriteLine($"Result={fig5.Area()}");

        }
    }
}
abstract public class Figure
{
    public abstract void Input();
    public abstract void Output();
    public abstract double Area();
}
class Square : Figure
{
    private double a;
    private double b;
    public override void Input()
    {
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
    }
    public override void Output()
    {
        Console.WriteLine($"a={a} | b= {b}");
    }
    public override double Area()
    {
        return a * b;
    }
}
class circle : Figure
{
    private double r;
    public override void Input()
    {
        r = double.Parse(Console.ReadLine());
    }
    public override void Output()
    {
        Console.WriteLine($"r={r}");
    }
    public override double Area()
    {
        return Math.PI * Math.Pow(r, 2);
    }
}
class Rhombus : Figure
{
    private double a;
    private double h;
    public override void Input()
    {
        a = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());
    }
    public override void Output()
    {
        Console.WriteLine($"a={a} | h={h}");
    }
    public override double Area()
    {
        return a * h;
    }
}
class Rectangle : Figure
{
    private double a;
    private double b;
    public override void Input()
    {
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
    }
    public override void Output()
    {
        Console.WriteLine($"a={a} | b={b}");

    }
    public override double Area()
    {
        return a * b;
    }
}
class Triangle : Figure
{
    private double a;
    private double b;
    private double c;
    public override void Input()
    {
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
    }
    public override void Output()
    {
        Console.WriteLine($"a={a} | b={b} | c={c}");
    }
    public override double Area()
    {
        return (a + b + c) / 2;
    }
}