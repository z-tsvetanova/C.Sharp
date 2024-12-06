namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House hause1 = new House();
            hause1.InputInfo();
            hause1.OutputInfo();
        }
    }
    class Building
    {
        private double height, area;
        private string address;

        public Building()
        {

        }
        public Building(double Height, double Area, string Address)
        {
            HEIGHT = Height;
            AREA = Area;
            ADDRESS = Address;
        }
        public double HEIGHT

        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double AREA
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public string ADDRESS
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
    }

    class House : Building
    {
        private int floors;
        private string ownername;

        public House() : base()
        {

        }
        public House(int Floors, string OwnerName, double Height, double Area, string Address) : base(Height, Area, Address)
        {
            FLOORS = Floors;
            OWNERNAME = OwnerName;

        }
        public int FLOORS
        {
            get
            {
                return floors;
            }
            set
            {
                floors = value;
            }
        }
        public string OWNERNAME
        {
            get
            {
                return ownername;
            }
            set
            {
                ownername = value;
            }
        }
        public void InputInfo()
        {
            Console.WriteLine("Vuvedete visochina na sgradata: ");
            HEIGHT = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete plosht na sgradata: ");
            AREA = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete address: ");
            ADDRESS = Console.ReadLine();
            Console.WriteLine("Broi etaji: ");
            FLOORS = int.Parse(Console.ReadLine());
            Console.WriteLine("Ime na sobstvenik: ");
            OWNERNAME = Console.ReadLine();

        }
        public void OutputInfo()
        {
            Console.WriteLine("Informaciq za sgradata: ");
            Console.WriteLine($"Visochina : {HEIGHT} m | Plosht: {AREA} km2 \n" +
                $"Address: {ADDRESS} | Etaji: {FLOORS} | Sobstvenik: {OWNERNAME}");
        }
    }
}