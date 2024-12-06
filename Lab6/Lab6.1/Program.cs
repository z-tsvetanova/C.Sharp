namespace Lab6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangle tri1 = new triangle();
            tri1.input();
            if (tri1.output() == "triugulnik")
            {
                tri1.area();
            }
            else
            {
                Console.WriteLine("ne e triugulnik");
            }
        }
    }
    class triangle
    {
        private double a, b, c;

        public void input()
        {
            Console.WriteLine("a=");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            c = double.Parse(Console.ReadLine());

        }
        public string output() 
        {
            if (a + b > c && c + b > a && c + a > b)
            {
                return "triugulnik";
            }
            else
            {
                return "ne e triugulnik";
            }

        }
        public void area()
        {
            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Perimetur: {p:f2}");
            Console.WriteLine($"Lice : {S:f2}");
        }
    }
}