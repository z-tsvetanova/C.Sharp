namespace LAB_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            int c = int.Parse(Console.ReadLine());
            double D;
            D = b * b - 4 * a * c;
            Console.WriteLine("Diskriminanta={0}",D);
            double x1;
            double x2;
            x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
            x2 = ((-b)- Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("Koren x1={0}",x1);
            Console.WriteLine("Koren x2={0}", x2);



        }
    }
}