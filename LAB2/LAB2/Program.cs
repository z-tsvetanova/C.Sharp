namespace LAB2
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
            if (a == b && c == a && b == c)
            {
                Console.WriteLine("Ravnostranen");
            }
            else if (a == b && c != a && c != b)
            {
                Console.WriteLine("Ravnobedren");
            }
            else
            {
                Console.WriteLine("Raznostranen");
            }


        }
    }
}