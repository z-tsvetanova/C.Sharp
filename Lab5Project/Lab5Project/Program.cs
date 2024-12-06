using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Transactions;
using static Figure;

namespace Lab5Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure [] figures = new Figure[3];
            figures[0] = new CircleFigure(0); 
            figures[1] = new RectangleFigure(0,0); 
            figures[2] = new SquareFigure(0); 


            foreach (Figure figure in figures)
            {
                figure.InPut();
                figure.OutPut(); 
                Console.WriteLine($"Area: {figure.Area()}");
            }
        }
    }
}
public abstract class Figure
{
    protected string type;
    protected double height;
    protected double width;
    public Figure(double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    public abstract string Type { get; }
    public abstract void InPut();
    public abstract void OutPut();
    public abstract double Area();
    public double HEIGHT
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }
    public double WIDTH
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
        }
    }
    public class CircleFigure : Figure
    {
        private double radius;
        public CircleFigure(double radius) : base(0,0)
        {
            this.radius = radius;
            type = "circle";
        }
        public override string Type
        {
            get
            {
                return type;
            }
        }
        public override void InPut()
        {
            Console.WriteLine("Radius of circle:");
            radius = double.Parse(Console.ReadLine());
           
        }
        public override void OutPut()
        {
            Console.WriteLine($"Figure: {type}, Radius: {radius}");
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
    public class RectangleFigure : Figure
    {
        public RectangleFigure(double height, double width) : base(height, width)
        {
            type = "rectangle";
        }
        public override string Type
        {
            get
            {
                return type;
            }
        }
        public override void InPut()
        {
            Console.WriteLine("Height of Rectangle:");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Width of Rectangle:");
            width = double.Parse(Console.ReadLine());
        }
        public override void OutPut()
        {
            Console.WriteLine($"Figure: {type}, Height: {height}, Width: {width}");
        }
        public override double Area()
        {
            return height * width;

        }
    }
    public class SquareFigure : Figure
    {
        private double side;
        public SquareFigure(double side) : base(side, side)
        {
            this.side = side;
            type = "square";
        }
        public override string Type
        {
            get
            {
                return type;
            }
        }
        public override void InPut()
        {
            Console.WriteLine("Enter side Square:");
            side = double.Parse(Console.ReadLine());
            height = side;
            width = side;
        }
        public override void OutPut()
        {
            Console.WriteLine($"Figure: {type}, side: {side}"); 
        }

        public override double Area()
        {
            return side * side; 
        }
    }
    public abstract class FigureFactory
    {
        public abstract Figure GetFigure();
    }
    public class CircleFigureFactory : FigureFactory
    {
        private double radius;
        public CircleFigureFactory(double radius)
        {
            this.radius = radius;
        }
        public override Figure GetFigure()
        {
            return new CircleFigure(radius);
        }
    }
    public class RectangleFigureFactory : FigureFactory
    {
        private double height;
        private double width;
        public RectangleFigureFactory(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override Figure GetFigure()
        {
            return new RectangleFigure(height, width);
        }
    }
    public class SquareFigureFactory : FigureFactory
    {
        private double height;
        private double width;
        public SquareFigureFactory(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override Figure GetFigure()
        {
            return new SquareFigure(height);
        }
    }
}

