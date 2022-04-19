using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Let's calculate the area of objects . Type in: Triangle, Square or Rectangle");
            var mathObject = Console.ReadLine();

            switch (mathObject.ToLower()) { 
            
                case "triangle":
                    Console.WriteLine("Type in lenght of a side 'a' and a height 'b' ");
                    int sideAA = Convert.ToInt32(Console.ReadLine());
                    int heightB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The area of a triangle is: " + (0.5 * sideAA * heightB));
                    break;
                
                case "square":
                    Console.WriteLine("Type in lenght of a side 'a'");
                    int sideSquare = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The area of a square is: " + (sideSquare * sideSquare));
                    break;
                case "rectangle":
                    Console.WriteLine("Type in lenght of sides 'a' and 'b' ");
                    int sideA = Convert.ToInt32(Console.ReadLine());
                    int sideB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The area of a rectangle is: " + (sideA * sideB));
                    break;

                default:
                    Console.WriteLine("Please provide one of values: Triangle, Square or Rectangle");
                  break;
            

            }
        }
    }
}
