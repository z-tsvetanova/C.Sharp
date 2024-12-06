using System.Reflection.Metadata.Ecma335;

namespace Lab62024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContinentalFactory factory1 = new AfricanFactory();
            Client client1 = new Client(factory1);
            client1.Run();

            IContinentalFactory factory2 = new AsiaticFactory();
            Client client2 = new Client(factory2);
            client2.Run();
        }
    }
}
public interface IElephant
{
    int GetWeight();
    int GetHeight();
    string GetLocality();
    string GetLatinName();
    string GetFood();
}
public interface ILion
{
    string GetFeatures();
    void CanMeet(IElephant elephant);
    string Locality();
    string LatinName();
    string Food();
}
public class AfricanElephant : IElephant
{
    public int GetWeight()
    {
        return 7500;
    }
    public int GetHeight()
    {
        return 4;
    }
    public string GetLocality()
    {
        return "Sub-Saharan Africa";
    }
    public string GetLatinName()
    {
        return "Loxodonta africana";
    }
    public string GetFood()
    {
        return "Grass, Leaf, Bark of tree, Fruits";
    }
}
public class IndianElephant : IElephant
{
    public int GetWeight()
    {
        return 6000;
    }
    public int GetHeight()
    {
        return 4;
    }
    public string GetLocality()
    {
        return "South, SouthEast Asia";
    }
    public string GetLatinName()
    {
        return "Elephas maximus indicus";
    }
    public string GetFood()
    {
        return "Grass, Leaf";
    }
}
public class AfricanLion : ILion
{
    public string GetFeatures()
    {
        return "Has a big mane";
    }
    public void CanMeet(IElephant elephant)
    {
        Console.WriteLine(this.GetType().Name + " Can meet " + elephant.GetType().Name);
    }
    public string Locality()
    {
        return "SouthWest";
    }
    public string LatinName()
    {
        return "Panthera leo bleyenberghi";
    }
    public string Food()
    {
        return "Animals";
    }
}
public class AsiaticLion : ILion
{
    public string GetFeatures()
    {
        return "Has a small mane";
    }
    public void CanMeet(IElephant elephant)
    {
        Console.WriteLine(this.GetType().Name + " Can meet " + elephant.GetType().Name);
    }
    public string Locality()
    {
        return "South Greek";
    }
    public string LatinName()
    {
        return "Panthera leo persica";
    }
    public string Food()
    {
        return "Animals";
    }
}
public interface IContinentalFactory
{
    ILion CreateLion();
    IElephant CreateElephant();
}
public class AfricanFactory : IContinentalFactory
{
    public ILion CreateLion()
    {
        return new AfricanLion();
    }
    public IElephant CreateElephant()
    {
        return new AfricanElephant();
    }
}
public class AsiaticFactory : IContinentalFactory
{
    public ILion CreateLion()
    {
        return new AsiaticLion();
    }
    public IElephant CreateElephant()
    {
        return new IndianElephant();
    }
}
public class Client
{
    private ILion lion;
    private IElephant elephant;
    public Client(IContinentalFactory factory)
    {
        lion = factory.CreateLion();
        elephant = factory.CreateElephant();
    }
    public void Run()
    {
        Console.WriteLine(elephant.GetType().Name + " weight: " + elephant.GetWeight() + " kg");
        Console.WriteLine(elephant.GetType().Name + " is tall: " + elephant.GetHeight() + "m");
        Console.WriteLine(lion.GetType().Name + " features: " + lion.GetFeatures());

        Console.WriteLine(elephant.GetType().Name + " locality: " + elephant.GetLocality());
        Console.WriteLine(elephant.GetType().Name + " Latin name: " + elephant.GetLatinName());
        Console.WriteLine(elephant.GetType().Name + " food: " + elephant.GetFood());


        lion.CanMeet(elephant);
    }
}


