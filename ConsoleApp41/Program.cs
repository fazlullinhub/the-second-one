using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    interface IShape
    {
        double CalculateArea();
        class Circle : IShape
        {
            public int Radius { get; set; }

            public Circle(int radius)
            {
                Radius = radius;
            }

            public double CalculateArea()
            {
                return Radius;
            }
            class Rectangle : IShape
            {
                public int Length { get; set; }
                public int Width { get; set; }

                public Rectangle(int length, int width)
                {
                    Length = length;
                    Width = width;
                }

                public double CalculateArea()
                {
                    return Length * Width;
                }
            }
            class Program
            {
                static void Main(string[] args)
                {
                    IShape circle = new Circle(5);
                    IShape rectangle = new Rectangle(4, 6);

                    Console.WriteLine($"Area of the circle: {circle.CalculateArea()}");
                    Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea()}");
                }
            }
        }
    }
}
