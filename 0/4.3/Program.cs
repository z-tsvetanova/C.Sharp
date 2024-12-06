using System.Threading.Channels;

namespace _4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rect = new rectangle();
            point point1 = new point();
            rect.input();
            point1.input();
            int a1, b1, x1, y1;
            a1 = rect.sideA();
            b1 = rect.sideB();
            x1 = point1.sideX();
            y1 = point1.sideY();
            if(a1==x1&&b1==y1)
            {
                int S = 0;
                S = rect.output();
                Console.WriteLine(S);
            }
            else
            {
                Console.WriteLine("Kordinatite x1 i y1 ne suvpadat sus stranite na pravougulnika");
            }
        }
        public class rectangle
        {
            private int a, b;


            public void input()
            {
                Console.WriteLine("a=");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("b=");
                b = int.Parse(Console.ReadLine());
            }
            public int sideA()
            {
                return a;
            }
            public int sideB()
            {
                return b;
            }



            public int output()
            {
                return a * b;
            }

        }
        public class point
        {

            private int x, y;
            public void input()
            {
                Console.WriteLine("x=");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("y=");
                y = int.Parse(Console.ReadLine());
            }
            public int sideX()
            {
                return x;
            }
            public int sideY()
            {
                return y;
            }

        }
    }
}