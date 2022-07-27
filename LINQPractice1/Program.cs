using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Query syntax: ");

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var query = from n in list1
                        select n * n;
            foreach (var num in query)
                Console.WriteLine(num);

            Console.WriteLine("Method syntax: ");

            //var query1 = list3.Where(n => n < 3);
            var query1 = list1.Select(x => x * x);
            foreach (var num in query1)
                Console.WriteLine(num);

        }
    }
}
