using System.Transactions;

namespace ooof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            time time1 = new time();
            time1.input();
            time1.output();
        }
    }
}
class time
{
    private int hour, minute, second;
    public time()
    {
        hour = 0;
        minute = 0;
        second = 0;
    }
    public time(int Hour,int Minute,int Second)
    {
        hour = Hour;
        minute = Minute;
        second = Second;
    }
    public void input()
    {
        hour = int.Parse(Console.ReadLine());
        minute = int.Parse(Console.ReadLine());
        second = int.Parse(Console.ReadLine());
    }
    public void output()
    {
        Console.WriteLine($"hour {hour} minute {minute} second {second}");
    }
}