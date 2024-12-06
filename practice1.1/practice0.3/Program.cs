namespace practice0._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rectangle1 = new rectangle();
            rectangle1.input();
            Console.WriteLine($" rectangle = " + rectangle1.area());
            ///////
            circle circle1 =new circle();   
            circle1.input();
            Console.WriteLine($" circle = " + circle1.area());
            ///////
            square square1 = new square();
            square1.input();
            Console.WriteLine($" square = " + square1.area());
        }
        
    }
    class rectangle
    {
        private int a, b;
        public rectangle()
        {
            ///////
        }
        public rectangle(int c, int d)
        {
            a = c;
            b = d;
        }
        public void input()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($" a { a } : b { b }");
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
            ///////
        }
        public circle(double r)
        {
            radius = r;
        }
        public void input()
        {
            radius = double.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($" radius : { radius } ");
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
            ///////
        }
        public square(int b)
        {
            a = b;
        }
        public void input()
        {
            a = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($" square : { a } ");
        }
        public int area()
        {
            return a * a;
        }

    }

}