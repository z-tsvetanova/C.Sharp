using System.Reflection.Metadata.Ecma335;

namespace Lab620242
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
public abstract class Elephant
{
    public abstract int GetWeight();
    public abstract int GetHeight();
    public abstract string GetLocality();
    public abstract string GetLatinName();
    public abstract string GetFood();
}
public abstract class Lion
{
    public abstract string GetFeatures();
    public abstract void CanMeet(Elephant elephant);
    public abstract string GetLocality();
    public abstract string GetLatinName();
    public abstract string GetFood();

}
public class AfricanElephant : Elephant
{
    public override int GetWeight()
    {
        return 7500;
    }
    public override int GetHeight()
    {
        return 4;
    }
    public override string GetLocality()
    {
        return "Sub-Saharan Africa";
    }
    public override string GetLatinName()
    {
        return "Loxodonta africana";
    }
    public override string GetFood()
    {
        return "Grass, Leaf, Bark of tree, Fruits";
    }
}
public class IndianElephant : Elephant
{
    public override int GetWeight()
    {
        return 6000;
    }
    public override int GetHeight()
    {
        return 3;
    }
    public override string GetLocality()
    {
        return "South, SouthEast Asia";
    }
    public override string GetLatinName()
    {
        return "Elephas maximus indicus";
    }
    public override string GetFood()
    {
        return "Grass, Leaf";
    }
}
public class AfricanLion : Lion
{
    public override string GetFeatures()
    {
        return "Has a big mane";
    }
    public override void CanMeet(Elephant elephant)
    {
        Console.WriteLine(this.GetType().Name + " can meet " + elephant.GetType().Name);
    }
    public override string GetLocality()
    {
        return "SouthWest";
    }
    public override string GetLatinName()
    {
        return "Panthera leo bleyenberghi";
    }
    public override string GetFood()
    {
        return "Animals";
    }
}
public class AsiaticLion : Lion
{
    public override string GetFeatures()
    {
        return "Has a small mane";
    }
    public override void CanMeet(Elephant elephant)
    {
        Console.WriteLine(this.GetType().Name + " can meet " + elephant.GetType().Name);
    }
    public override string GetLocality()
    {
        return "South Greek";

    }
    public override string GetLatinName()
    {
        return "Panthera leo persica";
    }
    public override string GetFood()
    {
        return "Animals";
    }
}
public abstract class IContinentalFactory
{
    public abstract Elephant GetElephant();
    public abstract Lion GetLion();
}
public class AfricanFactory : IContinentalFactory
{
    public override Elephant GetElephant()
    {
        return new AfricanElephant();
    }
    public override Lion GetLion()
    {
        return new AfricanLion();
    }
}
public class AsiaticFactory : IContinentalFactory
{
    public override Elephant GetElephant()
    {
        return new IndianElephant();
    }
    public override Lion GetLion()
    {
        return new AsiaticLion();
    }
}
public class Client
{
    private Elephant elephant;
    private Lion lion;
    public Client(IContinentalFactory factory)
    {
        elephant = factory.GetElephant();
        lion = factory.GetLion();
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


