namespace Practice0._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle circle1 = new circle(3); //suzdavame si nov obekt circle1 i mu podavame chisloto 3 zashtoto konstruktora ochakva realno chislo ot tip r
            Console.WriteLine($"radius = {circle1.Radius}"); //printirame stoinostta na svoistvoto Radius chrez obekt
            Console.WriteLine($"area = {circle1.area}");  //izvikvame svoistvoto area koeto ni vrushta liceto na kruga
            Console.WriteLine("Vuvedete noviq radius:");
            circle1.Radius=double.Parse(Console.ReadLine());  //prezapisvame nova stoinost na svoistvoto kato vuvejdame chislo ot klaviaturata
            Console.WriteLine($"Noviq radius = {circle1.Radius}"); //printirame novata stoinost
            Console.WriteLine($"New area = {circle1.area}"); //Tui kato sme smenili stoinostta na svoistvoto Radius formuulata sushto shte se promeni

        }
    }
    class circle
    {
        private double radius;  //pole
        public circle()
        {
            ////prazen konstruktor
        }
        public circle(double r) ///konstruktor s parametur r koito vzima stoinostta na radius
        {
            radius = r; 

        }
        public double area //svoistvo area koeto chrez get vrushta formulata za lice
        {
            get
            {
                return Math.PI*(radius * radius);
            }  
        }
        public double Radius //svoistvo koeto zapisva stoinostta na poleto radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }

        }


    }
}