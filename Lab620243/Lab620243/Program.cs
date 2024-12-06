namespace Lab620243
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Blue Factory:");
            IFigureFactory factory1 = new BlueFactory();
            Client client1 = new Client(factory1);
            client1.OutPut();

            Console.WriteLine("Red factory: ");
            IFigureFactory factory2 = new RedFactory();
            Client client2 = new Client(factory2);
            client2.OutPut();
        }
    }
}
public interface Circle
{
    string FigureType();
}
public interface Rectangle
{
    string FigureType();
}
public interface Square
{
    string FigureType();
}
public class BlueCircle : Circle
{
    public string FigureType()
    {
        return "blue circle";
    }
}
public class BlueRectangle : Rectangle
{
    public string FigureType()
    {
        return "blue rectangle";
    }
}
public class BlueSquare : Square
{
    public string FigureType()
    {
        return "blue square";
    }
}
public class RedCircle : Circle
{
    public string FigureType()
    {
        return "red circle";
    }
}
public class RedRectangle : Rectangle
{
    public string FigureType()
    {
        return "red rectangle";
    }
}
public class RedSquare : Square
{
    public string FigureType()
    {
        return "red square";
    }
}
public interface IFigureFactory
{
    Circle CreateCircle();
    Rectangle CreateRectangle();
    Square CreateSquare();
}
public class BlueFactory : IFigureFactory
{
    public Circle CreateCircle()
    {
        return new BlueCircle();
    }
    public Rectangle CreateRectangle()
    {
        return new BlueRectangle();
    }
    public Square CreateSquare()
    {
        return new BlueSquare();
    }
}
public class RedFactory : IFigureFactory
{
    public Circle CreateCircle()
    {
        return new RedCircle();
    }
    public Rectangle CreateRectangle()
    {
        return new RedRectangle();
    }
    public Square CreateSquare()
    {
        return new RedSquare();
    }
}
public class Client
{
    private Circle circle;
    private Rectangle rectangle;
    private Square square;
    public Client(IFigureFactory factory)
    {
        circle = factory.CreateCircle();
        rectangle = factory.CreateRectangle();
        square = factory.CreateSquare();
    }
    public void OutPut()
    {
        Console.WriteLine($"{circle.FigureType()}");
        Console.WriteLine($"{rectangle.FigureType()}");
        Console.WriteLine($"{square.FigureType()}");
    }
}
