using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> person = new Dictionary<int, string>();
            person.Add(1, "Jack");
            person.Add(2, "Bill");
            person.Add(3, "Drake");
            person.Add(4, "John");
            person.Add(5, "Adam");

            Console.WriteLine("Please enter number from 1 to 5");

            int number = Convert.ToInt32(Console.ReadLine());

            if (person.ContainsKey(number))
                Console.WriteLine("Corresponding name is " + person[number]);

            else
                Console.WriteLine("Corresponding name is not exist");

        }
    }
}
