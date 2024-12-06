namespace Zadacha_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double km;
            Console.WriteLine("Kilometri=");
            km = double.Parse(Console.ReadLine());
            double Milles=km/ 1.609344;
            Console.WriteLine("Milles={0:F2}",Milles);
            double m;
            Console.WriteLine("m=");
            m = double.Parse(Console.ReadLine());
            double Killometers=m* 1.609344;
            Console.WriteLine("Killometers={0:F2}",Killometers);

        }
    }
}