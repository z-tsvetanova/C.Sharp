namespace lab10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AfricanLion Lion1 = new AfricanLion();
            Lion1.InputAfrican();
            Lion1.OutputAfrican();
            AsiaticLion Lion2 = new AsiaticLion();
            Lion2.InputAsiatic();
            Lion2.OutputAsiatic();
        }
    }
    class Lion
    {
        double weight;
        double height;
        string NameType;
        string location;

        public Lion()
        {

        }
        public Lion(double Weight, double Height, string NameType, string Location)
        {
            WEIGHT = Weight;
            HEIGHT = Height;
            NAMETYPE = NameType;
            LOCATION = Location;

        }
        public double WEIGHT
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
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
        public string NAMETYPE
        {
            get
            {
                return NameType;
            }
            set
            {
                NameType = value;
            }
        }
        public string LOCATION
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
    }
    class AfricanLion : Lion
    {
        public AfricanLion()
        {

        }
        public AfricanLion(double Weight, double Height, string NameType, string Location) : base(Weight, Height, NameType, Location)
        {

        }
        public void InputAfrican()
        {
            Console.WriteLine("Vuvedete teglo: ");
            WEIGHT = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete visochina: ");
            HEIGHT = double.Parse(Console.ReadLine());
            NAMETYPE = "Panthera Leo";
            LOCATION = "Zapadna Afrika, Centralna Afrika i Indiq";

        }
        public void OutputAfrican()
        {
            Console.WriteLine($"Informaciq za Panthera Leo:");
            Console.WriteLine($"Teglo: {WEIGHT} | Visochina: {HEIGHT} | Naimenovanie: {NAMETYPE} | Mestoobitanie: {LOCATION}");
        }
    }
    class AsiaticLion : Lion
    {
        public AsiaticLion()
        {

        }
        public AsiaticLion(double Weight, double Height, string NameType, string Location) : base(Weight, Height, NameType, Location)
        {

        }
        public void InputAsiatic()
        {
            Console.WriteLine("Vuvedete teglo: ");
            WEIGHT = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete visochina: ");
            HEIGHT = double.Parse(Console.ReadLine());
            NAMETYPE = "Panthera leo persica";
            LOCATION = "Indiq";

        }
        public void OutputAsiatic()
        {
            Console.WriteLine($"Informaciq za Panthera leo persica: ");
            Console.WriteLine($"Teglo: {WEIGHT} | Visochina: {HEIGHT} | Naimenovanie: {NAMETYPE} | Mestoobitanie: {LOCATION}");
        }
    }
}