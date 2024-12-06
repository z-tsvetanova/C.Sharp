namespace Lab82024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder [] vehicleBuilders = new VehicleBuilder[3];
            Director producer = new Director();

            vehicleBuilders[0] = new CarBuilder();
            producer.Construct(vehicleBuilders[0]);
            vehicleBuilders[0].Vehicle.Show();

            vehicleBuilders[1] = new MotorcycleBuilder();
            producer.Construct(vehicleBuilders[1]);
            vehicleBuilders[1].Vehicle.Show();

            vehicleBuilders[2] = new BusBuilder();
            producer.Construct(vehicleBuilders[2]);
            vehicleBuilders[2].Vehicle.Show();

        }
    }
}
public class Vehicle  //1.Suzdava se klas opisvasht prevozno sredstvo
{
    private string vehicleType;
    private List <string> parts = new List<string>();
    public Vehicle(string type)
    { 
        vehicleType = type;
    }
    public void Add(string part)
    {
        parts.Add(part);
    }
    public void Show()
    {
        Console.WriteLine(vehicleType);
        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
    }
}
public abstract class VehicleBuilder  //2.Suzdava se abstrakten bazov klas suotvestvasht na stroitel
{
    protected Vehicle vehicle;
    public Vehicle Vehicle
    {
        get
        {
            return vehicle;
        }
    }
    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildDoors();
    public abstract void BuildSeats();
}
public class CarBuilder : VehicleBuilder  //3.Suzdavat se proizvodnite klasove koito suotvestvat na konkretnite stroiteli
{
    public CarBuilder()
    {
        vehicle = new Vehicle("Car");
    }
    public override void BuildFrame()
    {
        vehicle.Add("Car Frame");
    }
    public override void BuildEngine()
    {
        vehicle.Add("Engine 2500cc");
    }
    public override void BuildWheels()
    {
        vehicle.Add("Wheels 4");
    }
    public override void BuildDoors()
    {
        vehicle.Add("Doors");
    }
    public override void BuildSeats()
    {
        vehicle.Add("Seats 4");
    }
}
public class MotorcycleBuilder : CarBuilder
{
    public MotorcycleBuilder()
    {
        vehicle = new Vehicle("Motorcycle");
    }
    public override void BuildFrame()
    {
        vehicle.Add("Motorcycle Frame");
    }
    public override void BuildEngine()
    {
        vehicle.Add("Engine 500cc");
    }
    public override void BuildWheels()
    {
        vehicle.Add("Wheels 2");
    }
    public override void BuildDoors()
    {
        vehicle.Add("Doors 0");
    }
    public override void BuildSeats()
    {
        vehicle.Add("Seats 2");
    }
}
public class BusBuilder : VehicleBuilder
{
    public BusBuilder()
    {
        vehicle = new Vehicle("Bus");
    }
    public override void BuildFrame()
    {
        vehicle.Add("Bus Frame");
    }
    public override void BuildEngine()
    {
        vehicle.Add("Engine 150cc");
    }
    public override void BuildWheels()
    {
        vehicle.Add("Wheels 4");
    }
    public override void BuildDoors()
    {
        vehicle.Add("Doors 2");
    }
    public override void BuildSeats()
    {
        vehicle.Add("Seats 40");
    }
}
public class Director()
{
    public void Construct(VehicleBuilder vehicleBuilder)
    {
        vehicleBuilder.BuildFrame();
        vehicleBuilder.BuildEngine();
        vehicleBuilder.BuildWheels();
        vehicleBuilder.BuildDoors();
        vehicleBuilder.BuildSeats();
    }
}
