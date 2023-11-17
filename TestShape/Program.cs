using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape;

namespace TestShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape.Triangle triangle = new Shape.Triangle(30, 23, 13);
            Console.WriteLine(triangle.Area);
            Console.WriteLine(triangle.CalculateArea());
            Console.ReadKey();
        }
    }
}
