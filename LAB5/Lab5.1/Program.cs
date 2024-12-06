namespace Lab5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            skorost speed1 = new skorost();
            skorost speed2 = new skorost();
            speed1.InputKM();
            double KMtoMS = skorost.KMtoMS(speed1);
            Console.WriteLine("Kilometri v milisekundi = {0:F2}", KMtoMS);

            speed2.InputMS();
            double MstoKM = skorost.MStoKM(speed2);
            Console.WriteLine("Milisekundi v kilometri= {0:F2}", MstoKM);

        }
    }
    class skorost
    {
        private double KM, MS;
        public void InputKM()
        {
            Console.WriteLine("Vuvedete kilometri v chas");
            KM = double.Parse(Console.ReadLine());

        }
        public void InputMS()
        {
            Console.WriteLine("Vuvedete mili v chas");
            MS = double.Parse(Console.ReadLine());

        }
        public static double KMtoMS(skorost a)
        {
            double km1 = a.KM;
            double Milles = km1 / 1.609344;
            return Milles;
        }
        public static double MStoKM(skorost b)
        {
            double ms1 = b.MS;
            double Killometers = ms1 * 1.609344;
            return Killometers;
        }
    }
}