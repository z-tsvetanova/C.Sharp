namespace oof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure fig1;
            fig1 = new Rectangle();
            fig1.InPut();
            fig1.OutPut();
            Console.WriteLine($" result = " + fig1.Area());

            Figure fig2;
            fig2 = new Circle();
            fig2.InPut();
            fig2.OutPut();
            Console.WriteLine($" result = " + fig2.Area());

        }
    }
}
abstract public class Figure
{
    public abstract void InPut();
    public abstract void OutPut();
    public abstract double Area();
}
public class Rectangle : Figure
{
    private double a;
    public override void InPut()
    {
        a = double.Parse(Console.ReadLine());
    }
    public override void OutPut()
    {
        Console.WriteLine($"a = {a}");
    }
    public override double Area()
    {
        return a * a;
    }
}
public class Circle:Figure
{
    private double r;
    public override void InPut()
    {
        r = double.Parse(Console.ReadLine());
    }
    public override void OutPut()
    {
        Console.WriteLine($"r = {r}");
    }
    public override double Area()
    {
        return Math.PI * r * r;
    }
}