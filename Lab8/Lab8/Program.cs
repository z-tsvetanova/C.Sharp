namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rect1 = new rectangle();
            rectangle rect2 = new rectangle();
            rectangle rect3 = new rectangle();

            Console.WriteLine("Rect 1 :");
            rect1.X = int.Parse(Console.ReadLine());
            rect1.Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Rect 1 area : {rect1.Area}");

            Console.WriteLine("Rect 2 :");
            rect2.X = int.Parse(Console.ReadLine());
            rect2.Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Rect 2 area :{rect2.Area}");

            Console.WriteLine("Rect 3 :");
            rect3.X = int.Parse(Console.ReadLine());
            rect3.Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Rect 3 area {rect3.Area}");

            if (rect1.Area > rect2.Area && rect1.Area > rect3.Area)
            {
                Console.WriteLine($"Rectangle 1 e nai-golqm");
            }
            else if (rect2.Area > rect1.Area && rect2.Area > rect3.Area)
            {
                Console.WriteLine($"Rectangle 2 e nai-golqm");
            }
            else if (rect3.Area > rect1.Area && rect3.Area > rect2.Area)
            {
                Console.WriteLine($"Rectangle 3 e nai-golqm");
            }

        }
    }
    class rectangle
    {
        public int x;
        public int y;
        public int X
        {
            set
            {
                x = value;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
        }
        public int Area
        {
            get
            {
                return x * y;
            }
        }
        public rectangle()
        {
            x = 0;
            y = 0;
        }
        public rectangle(int x, int y )
        {
            this.x = x;
            this.y = y;
        }
    }
        
}