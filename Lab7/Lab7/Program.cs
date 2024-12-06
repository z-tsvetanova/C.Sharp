namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            time time1=new time();
            time1.input();
            time1.output();
        }
    }
    class time
    {
        private int hours;
        private int minutes;
        private int seconds;
        public time() 
        {
            //prazen konstruktor
        }
        public time(int h,int m,int s) //konstruktor s tri parametura koito davat stoinosti na poletata
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public void input()
        {
            Console.WriteLine("hours:");
            hours = int.Parse(Console.ReadLine());
            Console.WriteLine("minutes:");
            minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("seconds:");
            seconds = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($"hours : {hours} minutes : {minutes} seconds : {seconds}");
        }

    }

    

}