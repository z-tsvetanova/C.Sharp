namespace aaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rectangle1= new rectangle();
            Ifigure rectangle = rectangle1;
            rectangle.input();
            rectangle.output();
            Console.WriteLine($"result = " + rectangle.area());
        }
    }
}
interface Ifigure
{
    void input();
    void output();
    int area();
}
public class rectangle:Ifigure
{
    private int a;
    void Ifigure.input()
    {
        a = int.Parse(Console.ReadLine());
    }
    void Ifigure.output()
    {
        Console.WriteLine($"a {a}");
    }
    int Ifigure.area()
    {
        return a * a;
    }
}