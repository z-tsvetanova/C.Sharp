namespace study10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cat[] cat1 = { new Cat(), new Cat(), new Cat() };
            //foreach(var cat in cat1)
            //{
            //    cat.Info();
            //    cat.GetSound();
            //}
            //Dog[] dog1= {new Dog(), new Dog(), new Dog() };
            //{
            //    foreach(var dog in dog1)
            //    {
            //        dog.Info();
            //        dog.GetSound();
            //    }
            //}

            Cat[] cat1 = { new Cat(), new Cat(), new Cat() };
            for(int i=0;i<cat1.Length;i++)
            {
                cat1[i].Info();
                cat1[i].GetSound();
            }
        }
    }
}
public class Pet
{
    private string name;
    private int age;
    public Pet()
    {
        name = string.Empty;
        age = 0;
    }
    public Pet(string Name,int Age)
    {
        NAME = Name;
        AGE = Age;
    }
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
    public virtual void GetSound()
    {

    }
    public virtual void Info()
    {

    }
}
public class Cat:Pet
{
    public Cat()
    {

    }
    public Cat(string Name,int Age):base(Name,Age)
    {

    }
    public override void GetSound()
    {
        Console.WriteLine("Meow");

    }
    public override void Info()
    {
        NAME = Console.ReadLine();
        AGE = int.Parse(Console.ReadLine());
        Console.WriteLine("CAT INFO");
        Console.WriteLine($" Name : {NAME} Age {AGE}");
    }
}
public class Dog:Pet
{
    public Dog()
    {

    }
    public Dog(string Name,int Age):base(Name,Age)
    {

    }
    public override void GetSound()
    {
        Console.WriteLine("Borf");
    }
    public override void Info()
    {
        NAME = Console.ReadLine();
        AGE = int.Parse(Console.ReadLine());
        Console.WriteLine("DOG INFO");
        Console.WriteLine($" Name : {NAME} Age {AGE}");
    }
}


