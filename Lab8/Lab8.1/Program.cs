namespace Lab8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            Console.WriteLine("Model:");
            car1.Model = Console.ReadLine();
            Console.WriteLine("Cvqt");
            car1.Color = Console.ReadLine();
            Console.WriteLine("Nomer");
            car1.Number = Console.ReadLine();
            Console.WriteLine($"Model : {car1.Model} : Cvqt : {car1.Color} : Nomer : {car1.Number}");

        }
    }
    class car
    {
        private string model;
        private string color;
        private string number;
        public string Model
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
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }   
        }
        public car()
        {
            
        }
        public car(string model,string color,string number)
        {
            this.model = model;
            this.color = color;
            this.number = number;
        }
    }


}