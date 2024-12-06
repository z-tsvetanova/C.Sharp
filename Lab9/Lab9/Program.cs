namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete radius: ");
            double r = double.Parse(Console.ReadLine());
            figure fig = new figure(r);
            circle cir = new circle(r);
            Console.WriteLine($"Lice na krug: {cir.Area():f2}");
            double h = double.Parse(Console.ReadLine());
            cylinder cyl = new cylinder(r, h);
            Console.WriteLine($"Lice na cilindur: {cyl.Area():f2}");
            cone con = new cone(r);
            Console.WriteLine($"Lice na konus: {con.Area():f2}");
        }
    }
    class figure
    {

        public figure()
        {

        }
        public figure(double r)
        {

        }
    }
    class circle : figure
    {
        private double r;
        public circle()
        {

        }
        public circle(double r) : base(r)
        {
            radius = r;
            this.r = r;
        }
        public double radius
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }

        public double Area()
        {
            return Math.PI * (radius * radius);
        }
    }
    class cylinder : figure
    {
        private double r;
        private double h;
        public cylinder()
        {

        }
        public cylinder(double r, double h) : base(r)
        {
            this.H = h;
            this.R = r;
            this.h = h;
            this.r = r;

        }

        public double H
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        public double Area()
        {
            return Math.PI * Math.Pow(R, 2) * H;
        }

    }
    class cone : figure
    {
        public double r;
        public cone()
        {

        }
        public cone(double r) : base(r)
        {

            R = r;
            this.r = r;
        }
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        public double Area()
        {
            return (4 / 3) * Math.PI * Math.Pow(R, 3);
        }
    }
}