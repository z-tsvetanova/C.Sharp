namespace study3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            time time1 = new time();
            time1.InPut();
            time1.OutPut();

        }
    }
}
public class time
{
    private int hour,minute,second;
    public int HOUR
    {
        get
        {
            return hour;
        }
        set
        {
            hour = value;
        }
    }
    public int MINUTE
    {
        get
        {
            return minute;
        }
        set
        {
            minute = value;
        }
    }
    public int SECOND
    {
        get
        {
            return second;
        }
        set
        {
            second = value;
        }
    }
    public time()
    {
        hour = 0;
        minute = 0;
        second = 0;
    }
    public time(int Hour,int Minute,int Second)
    {
        HOUR = Hour;
        MINUTE = Minute;
        SECOND = Second;
    }
    public void InPut()
    {
        HOUR = int.Parse(Console.ReadLine());
        MINUTE = int.Parse(Console.ReadLine());
        SECOND = int.Parse(Console.ReadLine());
    }
    public void OutPut()
    {
        Console.WriteLine($" HH : {hour} : MM {minute} : SS : {second}");
    }

}