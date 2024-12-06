namespace aaaaaaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cat cat1 = new cat();
            cat1.Info();
            cat1.GetSound();
        }
    }
}
class pet
{
    private string name;
    public pet()
    {
        name = "";
        age = 0;
    }
    public pet(string Name,int Age)
    {
        NAME = Name;
        AGE = Age;
    }
    private int age;
    public string NAME { get; set; }
    public int AGE { get; set; }
    public virtual void GetSound()
    {

    }
    public virtual void Info()
    {

    }
}
class cat:pet
{
    public cat()
    {

    }
    public cat(string Name,int Age):base(Name,Age)
    {
        
    }
    public override void Info()
    {
        NAME = Console.ReadLine();
        AGE = int.Parse(Console.ReadLine());
        Console.WriteLine($" NAME {NAME} AGE {AGE}");
    }
    public override void GetSound()
    {
        Console.WriteLine("Meow");
    }

}