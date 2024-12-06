namespace Lab7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rectangle1 = new rectangle();
            rectangle1.input();
            Console.WriteLine($" area = " + rectangle1.area());
            circle circle1=new circle();
            circle1.input();
            Console.WriteLine($" area = " + circle1.area());
            square square1 = new square();
            square1.input();
            Console.WriteLine($" area = " + square1.area());
        }
    }
    class rectangle
    {
        private int a, b;
        public rectangle()

        {

        }
        public rectangle(int c, int d)
        {
            a = c;
            b = d;
        }
        public void input()
        {
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($" a : {a} b : {b}");

        }
        public int area()
        {
            return a * b;
        }
    }
    class circle
    {
        private double radius;
        public circle()
        {

        }
        public circle(double r)
        {
            radius = r;
        }
        public void input()
        {
            Console.WriteLine("radius:");
            radius = double.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($"radius : {radius}");
        }
        public double area()
        {
            return Math.PI * radius * radius;
        }
    }
    class square
    {
        private int a;
        public square()
        {

        }
        public square(int b)
        {
            a = b;
        }
        public void input()
        {
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($"a : {a}");
        }
        public int area()
        {
            return a * a;
        }
    }


}