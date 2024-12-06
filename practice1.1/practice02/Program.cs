namespace practice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            time time = new time();
            time.input();
            time.output();
        }
       
    }
    class time
    {
        private int hours, minutes, seconds;
        public time()
        {
            ///////

        }
        public time(int h, int m,int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public void input()
        {
            hours = int.Parse(Console.ReadLine());
            minutes = int.Parse(Console.ReadLine());
            seconds = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($" hours : {hours} : minutes {minutes} : seconds {seconds}");
        }
    }
}