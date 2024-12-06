namespace Lab9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.Input();
            stud.Output();
        }
    }
    class Person
    {
        private string Name;
        private double EGN;
        private string Card;

        public Person()
        {

        }
        public Person(string name, double egn, string card)
        {
            Name = name;
            EGN = egn;
            Card = card;
        }
        //public string NAME
        //{
        //    get
        //    {
        //        return Name;
        //    }
        //    set
        //    {
        //        Name = value;
        //    }
        //}
        //public int EGENE
        //{
        //    get
        //    {
        //        return EGN;
        //    }
        //    set
        //    {
        //        EGN = value;
        //    }
        //}
        //public string CARD
        //{
        //    get
        //    {
        //        return Card;
        //    }
        //    set
        //    {
        //        Card = value;
        //    }
        //}



    }
    class Student : Person
    {
        private string Specialty;
        private int Group;
        private double FKNumber;

        public Student()
        {

        }
        public Student(string specialty, int group, double fknumber, string Name, double EGN, string Card) : base(Name, EGN, Card)
        {
            Specialty = specialty;
            Group = group;
            FKNumber = fknumber;
            NAME = Name;
            EGNE = EGN;
            CARD = Card;
        }
        public string NAME { get; set; }
        public double EGNE { get; set; }
        public string CARD { get; set; }

        public string SPECIALTY
        {
            get
            {
                return Specialty;
            }
            set
            {
                Specialty = value;
            }
        }
        public int GROUP
        {
            get
            {
                return Group;
            }
            set
            {
                Group = value;
            }
        }
        public double FKNUMBER
        {
            get
            {
                return FKNumber;
            }
            set
            {
                FKNumber = value;
            }
        }
        public void Input()
        {
            Console.WriteLine("Vuvedete ime: ");
            NAME = Console.ReadLine();
            Console.WriteLine("Vuvedete egn: ");
            EGNE = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete karta: ");
            CARD = Console.ReadLine();
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine("Vuvedete specialnost: ");
            SPECIALTY = Console.ReadLine();
            Console.WriteLine("Vuvedete nomer na grupa: ");
            GROUP = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete fakulteten nomer: ");
            FKNUMBER = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("OBSHTA INFORMACIQ");
            Console.WriteLine("||||||||||||||||||||||||||||||");
            Console.WriteLine($"Ime: {NAME} EGN: {EGNE} Karta: {CARD}");
            Console.WriteLine($"Specialnost: {SPECIALTY} Grupa: {GROUP} Fk-nomer {FKNUMBER}");
            Console.WriteLine("||||||||||||||||||||||||||||||");
        }
    }
}