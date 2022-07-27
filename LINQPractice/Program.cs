using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select numbers via csharp resources");

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            foreach (int number in list1)
                if (number < 3)
                    Console.WriteLine(number);

            Console.WriteLine("Select numbers via linq");

            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var query = from n in list2
                        where n < 3
                        select n;
            foreach (var num in query)
                Console.WriteLine(num);

            Console.WriteLine("Select numbers via linq - method syntax");
            List<int> list3 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //var query1 = list3.Where(n => n < 3);
            var query1 = list3.Where(Numbers1);
            foreach (var num in query1)
                Console.WriteLine(num);

        }

        public static bool Numbers1(int i)
            {
                 return i<3;
            }
    }
}
