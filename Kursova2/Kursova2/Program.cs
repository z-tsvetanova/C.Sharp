namespace Kursova2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            laptop[] laptop1 = { new laptop(), new laptop(), new laptop(), new laptop(), new laptop() };
            laptop[] laptop2 = { new laptop(), new laptop(), new laptop(), new laptop(), new laptop() };

            for (int i = 0; i < laptop1.Length; i++)
            {
                laptop1[i].InPut();
                laptop2[i] = laptop1[i];
            }

            Console.WriteLine("Informaciq za vsichki produkti:");
            laptop.Output(laptop2);
            Console.WriteLine(" ");
            Console.WriteLine("Sortirane po cena: ");
            laptop.OutputSorted(laptop1);
        }
    }
    }
    class laptop
    {
        private string marka;
        private string model;
        private string razmernaekrana;
        private double cena;
        public laptop()
        {
            marka = " ";
            model = " ";
            razmernaekrana = " ";
            cena = 0.0;
        }
        public laptop(string Marka, string Model, string Razmernaekrana, double Cena)
        {
            MARKA = Marka;
            MODEL = Model;
            RAZMERNAEKRANA = Razmernaekrana;
            CENA = Cena;
        }
        public static void Output(laptop[] laptop2)
        {

            foreach (var laptop in laptop2)
            {
                Console.WriteLine($" Marka na laptop : {laptop.marka} | Model na laptop: {laptop.model} | Razmer na ekrana: {laptop.razmernaekrana} | Cena na laptop : {laptop.cena} lv");
            }
        }
        public static void OutputSorted(laptop[] laptop1)
        {

            foreach (var laptop in laptop1.OrderByDescending(x => x.cena))
            {
                Console.WriteLine($" Cena na laptop : {laptop.cena} lv | Marka na laptop : {laptop.marka}");
            }
        }
        public string MARKA
        {
            get
            {
                return marka;
            }
            set
            {
                marka = value;
            }
        }
        public string MODEL
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string RAZMERNAEKRANA
        {
            get
            {
                return razmernaekrana;
            }
            set
            {
                razmernaekrana = value;
            }
        }
        public double CENA
        {
            get
            {
                return cena;
            }
            set
            {
                cena = value;
            }
        }
        public void InPut()
        {
            Console.WriteLine("Vuvedi marka :");
            MARKA = Console.ReadLine();

            Console.WriteLine("Vuvedi model :");
            MODEL = Console.ReadLine();

            Console.WriteLine("Vuvedi razmer na ekrana:");
            RAZMERNAEKRANA = Console.ReadLine();

            Console.WriteLine("Vuvedi cena :");
            CENA = double.Parse(Console.ReadLine());
        }

    }

