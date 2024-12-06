namespace lab10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square();
            Rectangle rectangle1 = new Rectangle();
            Rhombus rhombus1 = new Rhombus();
            Parallelogram parallelogram1 = new Parallelogram();
            //////////////////////////////////////////////////
            square1.Input();
            square1.Area();
            rectangle1.Input();
            rectangle1.Area();
            rhombus1.Input();
            rhombus1.Area();
            parallelogram1.Input();
            parallelogram1.Area();

        }
    }

}
class Figure
{
    private double a;
    private double b;
    private double h;

    public Figure()
    {

    }
    public Figure(double A, double B, double H)
    {
        this.A = A;
        this.B = B;
        this.H = H;
    }
    public double A
    {
        get { return a; }
        set { a = value; }
    }
    public double B
    {
        get { return b; }
        set { b = value; }
    }
    public double H
    {
        get { return h; }
        set { h = value; }
    }
}
class Square : Figure
{
    public Square()
    {

    }
    public Square(double A, double B, double H) : base(A, B, H)
    {

    }
    public void Input()
    {
        Console.WriteLine("Vuvedete stranata a na kvadrat:");
        A = double.Parse(Console.ReadLine());
    }
    public void Area()
    {
        Console.WriteLine($"Lice na kvadrat: {A * A}");
    }
}
class Rectangle : Figure
{
    public Rectangle()
    {

    }
    public Rectangle(double A, double B, double H) : base(A, B, H)
    {

    }
    public void Input()
    {
        Console.WriteLine("Vuvedete strana na pravougulnika:");
        A = double.Parse(Console.ReadLine());
        Console.WriteLine("Vuvedete stranata b na pravougulnika:");
        B = double.Parse(Console.ReadLine());
    }
    public void Area()
    {
        Console.WriteLine($"Lice na pravougulnika {A * B}");
    }
}
class Rhombus : Figure
{
    public Rhombus()
    {

    }
    public Rhombus(double A, double B, double H) : base(A, B, H)
    {

    }
    public void Input()
    {
        Console.WriteLine("Vuvedete a na romb:");
        A = double.Parse(Console.ReadLine());
        Console.WriteLine("Vuvedete h na romb:");
        H = double.Parse(Console.ReadLine());
    }
    public void Area()
    {
        Console.WriteLine($"Lice na romb: {A * H}");
    }
}
class Parallelogram : Figure
{
    public Parallelogram()
    {

    }
    public Parallelogram(double A, double B, double H) : base(A, B, H)
    {

    }
    public void Input()
    {
        Console.WriteLine("Vuvedete b na usporednik:");
        B = double.Parse(Console.ReadLine());
        Console.WriteLine("Vuvedete h na usporednik:");
        H = double.Parse(Console.ReadLine());
    }
    public void Area()
    {
        Console.WriteLine($"Lice na usporednik: {B * H}");
    }
}