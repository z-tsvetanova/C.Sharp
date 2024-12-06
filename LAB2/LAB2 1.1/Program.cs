namespace LAB2_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int nf = 1;
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            while(i<=n)
            {
                nf = nf * i;
                i++;
            }
            Console.WriteLine(nf);

        }
    }
}