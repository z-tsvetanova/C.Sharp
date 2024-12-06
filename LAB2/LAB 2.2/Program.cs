namespace LAB_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<n;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            for(int i=n;i>=1;i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}