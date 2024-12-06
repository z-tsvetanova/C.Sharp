namespace Lab_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mA = new int[n];
            for (int i = 0; i < n; i++)
            {
                mA[i] = int.Parse(Console.ReadLine());

            }
            int[] mB = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (mA[i] > 0)
                {
                    mB[i] = mA[i];

                }
            }
            Console.WriteLine("Masiv A:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mA[i]);

            }
            Console.WriteLine("Masiv B:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mB[i]);

            }

        }
    }
}