using System.Xml.Schema;

namespace Lab820241
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

           
            SaladOptions saladOptions = new SaladOptions
            {
                HasSalad = true,
                HasOnion = true,
                HasCucumber = true,    
                HasTomato = true      
            };

            SandwichBuilder[] sandwichBuilders = new SandwichBuilder[2];

            
            sandwichBuilders[0] = new MeatSandwichLover();
            director.Construct(sandwichBuilders[0], saladOptions);
            sandwichBuilders[0].Sandwich.Show();

    
            sandwichBuilders[1] = new VeggieSandwichLover();
            director.Construct(sandwichBuilders[1], saladOptions);
            sandwichBuilders[1].Sandwich.Show();

        }
    }
}
public class Sandwich
{
    private string sandwichType;
    private string breadType;
    private List<string> ingredients = new List<string>();
    public Sandwich(string type)
    {
        sandwichType = type;
    }
    public void Add(string ingredient)
    {
        ingredients.Add(ingredient);
    }
    public void AddBreadType(string bread)
    {
        breadType = bread;
    }
    public void Show()
    {
        Console.WriteLine(sandwichType);
        Console.WriteLine($"Sandwich Type: {sandwichType}");
        Console.WriteLine($"Bread Type: {breadType}");
        foreach (string ingredient in ingredients)
        {
            Console.WriteLine(ingredient);
        }
    }
}
public class SaladOptions
{
    private bool hasOnion;
    private bool hasCucumber;
    private bool hasTomato;
    private bool hasSalad;
    public bool HasOnion { get { return hasOnion; } set { hasOnion = value; } }
    public bool HasCucumber { get { return hasCucumber; } set { hasCucumber = value; } }
    public bool HasTomato { get { return hasTomato; } set { hasTomato = value; } }
    public bool HasSalad { get { return hasSalad; } set { hasSalad = value; } }
}
public abstract class SandwichBuilder
{
    protected Sandwich sandwich;
    public Sandwich Sandwich
    {
        get
        {
            return sandwich;
        }
    }
    public abstract void BuildBread();
    public abstract void BuildMainProduct();
    public abstract void BuildSalad(SaladOptions options);
    public abstract void BuildPrice();
}
public class MeatSandwichLover : SandwichBuilder
{
    public MeatSandwichLover()
    {
        sandwich = new Sandwich("MeatSandwich");
    }
    public override void BuildBread()
    {
        sandwich.AddBreadType("White bread");
    }
    public override void BuildMainProduct()
    {
        sandwich.Add("Meat");
    }
    public override void BuildSalad(SaladOptions options)
    {
        if (options.HasOnion) sandwich.Add("Onion");
        if (options.HasCucumber) sandwich.Add("Cucumber");
        if (options.HasTomato) sandwich.Add("Tomato");
    }
    public override void BuildPrice()
    {
        sandwich.Add("14.99");
    }
}
public class VeggieSandwichLover : SandwichBuilder
{
    public VeggieSandwichLover()
    {
        sandwich = new Sandwich("VeggieSandwich");
    }
    public override void BuildBread()
    {
        sandwich.AddBreadType("Black Bread");
    }
    public override void BuildMainProduct()
    {
        sandwich.Add("Cheese");
    }
    public override void BuildSalad(SaladOptions options)
    {
        if (options.HasOnion) sandwich.Add("Cucumber");
        if (options.HasCucumber) sandwich.Add("Tomato");
        if (options.HasTomato) sandwich.Add("Iceberg Salad");
    }
    public override void BuildPrice()
    {
        sandwich.Add("14.99");
    }
}
public class Director()
{
    public void Construct(SandwichBuilder sandwichBuilder, SaladOptions options)
    {
        sandwichBuilder.BuildBread();
        sandwichBuilder.BuildMainProduct();
        sandwichBuilder.BuildSalad(options);
        sandwichBuilder.BuildPrice();
    }
}
