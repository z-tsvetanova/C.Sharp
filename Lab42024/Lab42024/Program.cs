using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



        }
    }
    public class Point
    {
        private double x, y;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Point()
        {

        }
        public Point(double x, double y) 
        { 
            this.x = x; 
            this.y = y; 
        }
        public void InPut()
        {
            Console.WriteLine("Point X");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Point Y");
            y = double.Parse(Console.ReadLine());
        }
        public void OutPut()
        {
            Console.WriteLine("Point X {0}",x);
            Console.WriteLine("Point Y {0}", y);
        }
        public void Translation(double Vx, double Vy)
        {
            x = x + Vx;
            y = y + Vy;
        }
        public void Rotation(double angle)
        {
            double x1;
            x1 = x*Math.Cos(angle) - x*Math.Sin(angle);
            double y1;
            y1 = y*Math.Sin(angle) + y*Math.Cos(angle);
            x = x1;
            y = y1;
        }
    }
    public class Vector
    {
        private double Vx, Vy;
        public double VX
        {
            get
            {
                return Vx;
            }
            set
            {
                Vx = value;
            }
        }
        public double VY
        {
            get
            {
                return Vy;
            }
            set
            {
                Vy = value;
            }
        }
        public void InPut()
        {
            Console.WriteLine("Vector Vx");
            Vx = double.Parse(Console.ReadLine());
            Console.WriteLine("Vector Vy");
            Vy = double.Parse(Console.ReadLine());
        }
        public void OutPut()
        {
            Console.WriteLine("Vector Vx {0}", Vx);
            Console.WriteLine("Vector VY {0}", Vy);
        }
    }
   public class Polygon
    {
        private Point [] array; //Deklarirane na masiv ot tochki
        public Point[] Array
        {
            get { return array; }
            set { array = value; }
        }
        public Polygon(int size)  //Konstruktora priema parametur size koito zadava razmera na masiva ot tochki
        {
            array = new Point[size]; //Suzdavam nov masiv s razmer size
            for (int i = 0; i < size; i++)  //Inicializiram vsqka tochka v masiva s nov obekt Point
            {
                array[i] = new Point();
            }
        }
    }
  
}
