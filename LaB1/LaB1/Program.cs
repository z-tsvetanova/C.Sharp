namespace LaB1
{
    internal class Program
    {
        static void Main(string[] args)
        { double P = 3.14;
            int n;
            Console.WriteLine("n=");
            n=int.Parse(Console.ReadLine());
            switch(n)
            {   
                case 1 : Console.WriteLine("Kvadrat");
                    int a;
                    Console.WriteLine("a="); 
                    a=int.Parse(Console.ReadLine());
                    int S = a * a;
                    Console.WriteLine("liceto na kvadrat={0}", S);
                    break;
                    case 2 : Console.WriteLine("Pravougulnik");
                    int b;
                    Console.WriteLine("a="); 
                    a =int.Parse(Console.ReadLine());
                    Console.WriteLine("b=");
                    b = int.Parse(Console.ReadLine());
                    S = a * b;
                    Console.WriteLine("Liceto na pravougulnik={0}", S);
                    break;
                    case 3 : Console.WriteLine("Krug");
                    double r;
                    Console.WriteLine("r=");
                    r = double.Parse(Console.ReadLine());
                    double S1;
                    S1 = P * r * r;
                    Console.WriteLine("licekrug={0:F2}", S1);
                    break;
                    case 4 : Console.WriteLine("Triugulnik");
                    int c;
                    Console.WriteLine("a=");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("b=");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("c=");
                    c = int.Parse(Console.ReadLine());
                    S = (a + b + c) / 2;
                    Console.WriteLine("liceto na triugulnika={0}", S);
                    break;
                    default: Console.WriteLine("Nqma takava figura");
                    break;










            }



        }
    }
}