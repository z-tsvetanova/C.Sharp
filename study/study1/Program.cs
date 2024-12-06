namespace study1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cat cat1 = new cat();
            //cat1.input();
            //cat1.output();

            cat[] cat1 = { new cat() };
            foreach (var cat in cat1)
            {
                cat.input();
                cat.output();
            }
        }
    }
}
public class cat
{
    private string name;
    private int age;
    public string NAME
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int AGE
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
    public cat()
    {
        name = "";
        age = 0;
    }
    public cat(string Name, int Age)
    {
        NAME = Name;
        AGE = Age;
    }
    public void input()
    {
        NAME = Console.ReadLine();
        AGE = int.Parse(Console.ReadLine());
    }
    public void output()
    {
        Console.WriteLine($" name of the cat : {name} | age of the cat : {age} |");
    }
}










