namespace Kursova2Obqsnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            laptop[] laptop1 = { new laptop(), new laptop(), new laptop(), new laptop(), new laptop() }; // masiva koito she sortirame
            laptop[] laptop2 = { new laptop(), new laptop(), new laptop(), new laptop(), new laptop() }; // masiva cher koito prosto printirame cqlata informaciq

            for (int i = 0; i < laptop1.Length; i++)//cherz tozi for cikul nie zapisvame vseki zapis ot ot ediniq masiv ot obekti v drugiq / taka te imat edni i sushti zapisi prosto rintiraneto im e razlichno
            {
                laptop1[i].InPut();// Na vseki obekt v laptop1 dostupvash Input() metoda chrez koito vuvejdash parametrite na vseki laptop
                laptop2[i] = laptop1[i];// zapisvash vuvedenie parametri za laptopa ot laptop1 v laptopa na laptop2 masiva / kato po tozi nachin stavat s ednakvi zapisi
            }

            Console.WriteLine("Informaciq za vsichki produkti:");
            laptop.Output(laptop2);// dostupvame metoda chrez imeto na klasa zashtoto e statichen i printirame informaciqta za vsichki laptopi
            Console.WriteLine(" ");
            Console.WriteLine("Sortirane po cena: ");
            laptop.OutputSorted(laptop1);// otnovo dostupvame metoda chrez imeto na klasa laptop obache tozi put izpolzvame sortiraniq metod koito raboti s masiva ot obekti laptop1
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
        public laptop(string Marka, string Model, string Razmernaekrana, double Cena) // Konstruktor koito dava stoinosti na poleta chrez svoistvata
        {
            MARKA = Marka;
            MODEL = Model;
            RAZMERNAEKRANA = Razmernaekrana;
            CENA = Cena;
        }
        public static void Output(laptop[] laptop2)//Statichen metod koito printirra informaciqta na masiva ot obekti (nesortiran)
        {

            foreach (var laptop in laptop2)//Izpolzvame foreach za da minem prez vsichki obekti ot masiva i da printirame tqhnata informaciq
            //var razpoznava vseki tip, za vseki laptop v masiva o obekti laptop2 mi printirai poletata laptop.marka, laptop.model i tn.
            {
                Console.WriteLine($" Marka na laptop : {laptop.marka} | Model na laptop: {laptop.model} | Razmer na ekrana: {laptop.razmernaekrana} | Cena na laptop : {laptop.cena} lv");
            }
        }
        public static void OutputSorted(laptop[] laptop1)//Statichen metod koito printira veche sortiran po cena masiv ot obekti na laptop1(vtoriq masiv ot klasove)
        {

            foreach (var laptop in laptop1.OrderByDescending(x => x.cena))//Otnovo izpolzvame foreach za vseki laptop v laptop1 samo che kum masiva izpolzvame gotoviq metod OrferByDescending i izpolzvame lamda funkciq za da kajem po koi kriterii(pole) iskame da printirame masiva.
                                                                          //Kak se dostupva x: chete se za vsqko x koeto e cena da se naredi po nizhodqsh red kakto e imeto na metoda koito polzvame.
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

}