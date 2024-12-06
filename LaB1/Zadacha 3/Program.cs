namespace Zadacha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("f=");
            double f = double.Parse(Console.ReadLine());
            double C = (f - 32) / 1.8;
            Console.WriteLine(C);
            Console.WriteLine("c=");
            double c = double.Parse(Console.ReadLine());
            double F=1.8*c + 32;
            Console.WriteLine(F);


            
        }
    }
}