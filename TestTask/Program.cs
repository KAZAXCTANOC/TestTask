using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskClassLibrary;
using TestTaskClassLibrary.Figures;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Circle circle = new Circle(5);
            Circle circle1 = new Circle(6);
            Circle circle2 = new Circle(7);
            Circle circle3 = new Circle(8);
            Triangle triangle = new Triangle(5, 5, 5);
            shapes.Add(circle);
            shapes.Add(circle1);
            shapes.Add(circle2);
            shapes.Add(circle3);
            shapes.Add(triangle);

            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetArea());
            }

            Console.ReadKey();
        }
    }
}
