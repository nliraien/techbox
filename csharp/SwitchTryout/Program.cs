using System;

namespace SwitchTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Square(5.0);
            Console.WriteLine(ComputeArea(s));
            var r = new Rectangle(4.2, 0);
            Console.WriteLine(ComputeArea(r));
        }

        public static double ComputeArea(object shape)
        {
            switch (shape)
            {
                case Square s when s.Side == 0:
                case Circle c when c.Radius == 0:
                case Rectangle r when r.Height == 0 || r.Length == 0:
                    return 0;
                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * Math.PI;
                case Rectangle r:
                    return r.Height * r.Length;
                default:
                    throw new ArgumentException();
            }
        }
    }

    public class Square
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }
    }

    public class Circle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public class Rectangle
    {
        public double Height { get; }
        public double Length { get; }

        public Rectangle(double height, double length)
        {
            Height = height;
            Length = length;
        }
    }
}
