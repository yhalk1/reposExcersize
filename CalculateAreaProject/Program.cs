using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateMethods;

namespace CalculateAreaProject
{

    public class Program
    {
        public static void TestMethod() { }
        static void Main(string[] args)
        {
            var CalculateAreas = new CalculateAreas();

            Console.WriteLine("Hi! Let's calculate the area of objects . Type in: Triangle, Square or Rectangle");
            var mathObject = Console.ReadLine();

            switch (mathObject.ToLower())
            {

                case "triangle":
                    Console.WriteLine("Type in lenght of a side 'a' and a height 'b' ");
                    var sideAA = Convert.ToDouble(Console.ReadLine());
                    var heightB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area of a triangle is: " + CalculateAreas.TriangleArea(sideAA, heightB));
                    break;

                case "square":
                    Console.WriteLine("Type in lenght of a side 'a'");
                    var sideSquare = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area of a square is: " + CalculateAreas.SquareArea(sideSquare));
                    break;

                case "rectangle":
                    Console.WriteLine("Type in lenght of sides 'a' and 'b' ");
                    var sideA = Convert.ToDouble(Console.ReadLine());
                    var sideB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area of a rectangle is: " + CalculateAreas.RectangleArea(sideA, sideB));
                    break;

                default:
                    Console.WriteLine("Please provide one of values: Triangle, Square or Rectangle");
                    break;
            }

        }
    }
}
