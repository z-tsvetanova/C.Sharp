namespace study7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.InPut();
            car1.BRAND = Console.ReadLine();
            car1.COLOR = Console.ReadLine();
            car1.REGISTERNUMBER = Console.ReadLine();
            Console.WriteLine($" {car1.BRAND} | {car1.COLOR} | {car1.REGISTERNUMBER}");
        }
    }
}
public class car
{
    private string brand;
    private string color;
    private string registernumber;
    public car()
    {
        brand = string.Empty;
        color = string.Empty;
        registernumber = string.Empty;
    }
    public car(string Brand, string Color, string RegisterNumber)
    {
        BRAND = Brand;
        COLOR = Color;
        registernumber = RegisterNumber;
    }
    public string BRAND
    {
        get
        {
            return brand;
        }
        set
        {
            brand = value;
        }
    }
    public string COLOR
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
    public string REGISTERNUMBER
    {
        get
        {
            return registernumber;
        }
        set
        {
            registernumber = value;
        }
    }
    public void InPut()
    {
        BRAND = Console.ReadLine();
        COLOR = Console.ReadLine();
        REGISTERNUMBER = Console.ReadLine();
        Console.WriteLine($" brand  : {brand} | color : {color} | register number :{registernumber}");
    }
}