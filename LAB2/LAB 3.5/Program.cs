namespace LAB_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            if (a >= 1 && a <= 3)
            {
                Console.WriteLine("Bebe");
            }
            else if (a >= 4 && a <= 13)
            {
                Console.WriteLine("Dete");
            }
            else if (a >= 14 && a <= 19)
            {
                Console.WriteLine("Tineidjur");
            }
            else if (a >= 20 && a <= 50)
            {
                Console.WriteLine("Vuzrasten");

            }
            else if (a>51)
            {
                Console.WriteLine("Pensiq");

            }
        }
    }
}