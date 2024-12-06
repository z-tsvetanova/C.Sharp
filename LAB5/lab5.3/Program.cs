namespace lab5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            number number1 = new number();
            number number2 = new number();
            number1.RealNumber();
            number2.ImaginerNumber();
            int result = number.result(number1, number2);
            Console.WriteLine(result);
        }
    }
    class number
    {
        private int rnumber, rnumber1, inumber, inumber1;
        public void RealNumber()
        {
            Console.WriteLine("Vuvedete realno chislo:");
            rnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete realno chislo:");
            rnumber1 = int.Parse(Console.ReadLine());

        }
        public void ImaginerNumber()
        {
            Console.WriteLine("Vuvedete imaginerno chislo:");
            inumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete imaginerno chislo:");
            inumber1 = int.Parse(Console.ReadLine());
        }
        public static int result(number a, number b)
        {
            int rn = a.rnumber;
            int rn1 = a.rnumber1;
            int inu = b.inumber;
            int inu1 = b.inumber1;
            int result = (rn + rn1) + (inu + inu1);
            return result;
        }

    }
}