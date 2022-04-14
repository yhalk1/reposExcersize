using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Let's check wther your number is even)");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is odd");
        }
    }
}
