using System.Diagnostics.Contracts;

namespace Lab620244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IJuiceFactory factory1 = new JuiceFactory();
            Client client1 = new Client(factory1);
            client1.OutPut();
        }
    }
}
public interface IAppleJuice
{
    string JuiceType();
    string JuiceFlavor();
    string JuiceIngredients();
}
public interface ICherryJuice
{
    string JuiceType();
    string JuiceFlavor();
    string JuiceIngredients();
}
public interface IOrangeJuice
{
    string JuiceType();
    string JuiceFlavor();
    string JuiceIngredients();
}
public class AppleJuice : IAppleJuice
{
    public string JuiceType()
    {
        return "Apple Juice";
    }
    public string JuiceFlavor()
    {
        return "Sweet with mild tartness.";
    }
    public string JuiceIngredients() 
    {
        return "Contains only freshly squeezed apples. It is rich in vitamins, fiber, and fruit acids.";
    }
}
public class CherryJuice : ICherryJuice
{
    public string JuiceType()
    {
        return "Cherry Juice";
    }
    public string JuiceFlavor()
    {
        return "Tart with a hint of sweetness.";
    }
    public string JuiceIngredients()
    {
        return "Contains freshly squeezed cherries and sour cherries. This juice is rich in antioxidants, anthocyanins, and natural melatonin.";
    }
}
public class OrangeJuice : IOrangeJuice
{
    public string JuiceType()
    {
        return "Orange juice";
    }
    public string JuiceFlavor()
    {
        return "Sweet and slightly tangy.";
    }
    public string JuiceIngredients()
    {
        return "Contains freshly squeezed oranges, including the pulp and core of the fruit. It is rich in vitamins and minerals";
    }
}
public interface IJuiceFactory
{
    IAppleJuice CreateAppleJuice();
    ICherryJuice CreateCherryJuice();
    IOrangeJuice CreateOrangeJuice();
}
public class JuiceFactory : IJuiceFactory
{
    public IAppleJuice CreateAppleJuice()
    {
        return new AppleJuice();
    }
    public ICherryJuice CreateCherryJuice()
    {
        return new CherryJuice();
    }
    public IOrangeJuice CreateOrangeJuice()
    {
        return new OrangeJuice();
    }
}
public class Client
{
    private IAppleJuice  applejuice;
    private ICherryJuice cherryjuice;
    private IOrangeJuice orangejuice;
    public Client(IJuiceFactory factory)
    {
        applejuice  = factory.CreateAppleJuice();
        cherryjuice = factory.CreateCherryJuice();
        orangejuice = factory.CreateOrangeJuice();
    }
    public void OutPut()
    {
        Console.WriteLine("Apple Juice:");
        Console.WriteLine($" - Type: {applejuice.JuiceType()}");
        Console.WriteLine($" - Flavor: {applejuice.JuiceFlavor()}");
        Console.WriteLine($" - Ingredients: {applejuice.JuiceIngredients()}");
        Console.WriteLine();

        Console.WriteLine("Cherry Juice:");
        Console.WriteLine($" - Type: {cherryjuice.JuiceType()}");
        Console.WriteLine($" - Flavor: {cherryjuice.JuiceFlavor()}");
        Console.WriteLine($" - Ingredients: {cherryjuice.JuiceIngredients()}");
        Console.WriteLine();

        Console.WriteLine("Orange Juice:");
        Console.WriteLine($" - Type: {orangejuice.JuiceType()}");
        Console.WriteLine($" - Flavor: {orangejuice.JuiceFlavor()}");
        Console.WriteLine($" - Ingredients: {orangejuice.JuiceIngredients()}");
        Console.WriteLine();

    }
}




