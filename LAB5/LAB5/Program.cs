namespace LAB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point po1 = new point();
            point po2 = new point();
            po1.input();
            po2.input();
            double result1 = point.distance(po1, po2);
            // Console.WriteLine(result1); 
            Console.WriteLine("rezultatut ot distranciqta e : {0:F2}", result1);
        }
    }
    public class point
    {
        private int x, y;
        public void input()
        {
            Console.WriteLine("x=");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("y=");
            y = int.Parse(Console.ReadLine());

        }
        public void output()
        {
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);
        }
        public static double distance(point a, point b)
        {
            int dx, dy;
            dx = a.x - b.x;
            dy = a.y - b.y;
            double result = Math.Sqrt(dx * dx + dy * dy);
            return result;
        }
    }

}