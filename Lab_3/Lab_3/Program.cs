using System.Collections.Concurrent;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            double[] mA = new double[n];
            for(int i=0;i<n;i++)
            {
                mA[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedete n element v masiv:");
            }
            Console.WriteLine("Chislata v prav red");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mA[i]);
            }
            Console.WriteLine("Chislata v obraten red");
            for(int i=n-1; i>=0; i--)
            {
                Console.WriteLine(mA[i]);
            }

        }
    }
}