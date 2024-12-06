namespace LAB_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Vuvedete 1 za kvadrat");
            Console.WriteLine("Vuvedete 2 za pravougulnik");
            Console.WriteLine("Vuvedete 3 za triugulnik");
            n = int.Parse(Console.ReadLine());
            int f = 0;
            switch(n)
            {
                case 1:
                f = 3;
                 for (int i = 0; i < f; i++)
                  {
                        Console.WriteLine("****");
                  }
                    break;
                case 2:
                f = 4;
                for (int i = 0; i < f; i++)
                 {
                        Console.WriteLine("*************");
                 }
                    break;
                case 3:
                 f = 4;
                    for (int i = 0; i < f; i++)
                    {

                        if (i == 0)
                        {
                            Console.WriteLine("*");
                        }
                        else if (i == 1)
                        {
                            Console.WriteLine("**");
                        }
                        else if(i==2)
                        {
                            Console.WriteLine("***");
                        }
                        else if(i==3)
                        {
                            Console.WriteLine("****");
                        }
                    }
                    break;

            }
            
            
        }
    }
}