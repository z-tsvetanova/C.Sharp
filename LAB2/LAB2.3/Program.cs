namespace LAB2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("a=");
            int a=int.Parse(Console.ReadLine());
            while(a!=0)
            {
                sum = sum + a;
                Console.WriteLine("Vuvedete a otnovo:");
                a = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(sum);

        }
           
        
    }
}