using System;
using System.Runtime.CompilerServices;

namespace _0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rect1 = new rectangle();
            rect1.Elements();
            int rectangleS = 0;
            rectangleS = rect1.Area();
            Console.WriteLine("Liceto na pravouglnika ={0}", rectangleS);

            triangle triangle1 = new triangle();
            triangle1.Elements();
            int triangleS = 0;
            triangleS = triangle1.Area();
            Console.WriteLine("Liceto na triugulnik ={0}", triangleS);

            circle circle1 = new circle();
            circle1.Elements();
            double circleS = 0;
            circleS = circle1.Area();
            Console.WriteLine("Liceto na krug={0:F2}", circleS);
        }
        public class rectangle
        {
            private int a, b;


            public void Elements()
            {
                Console.WriteLine("a=");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("b=");
                b = int.Parse(Console.ReadLine());
            }
            public int Area()
            {
                return a * b;
            }


        }
        public class triangle
        {
            private int a, b, c;

            public void Elements()
            {
                Console.WriteLine("a=");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("b=");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("c=");
                c = int.Parse(Console.ReadLine());

            }
            public int Area()
            {
                return (a + b + c) / 2;
            }
        }
        public class circle
        {
            private double r;
            

            public void Elements()
            {
                Console.WriteLine("r=");
                r = double.Parse(Console.ReadLine());
            }
            public double Area()
            {
                return Math.PI * r * r;
            }
        }

    }
}
