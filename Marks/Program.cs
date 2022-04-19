using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. What is your Role No?");
            string roleNo = Console.ReadLine();
            Console.WriteLine("Hi. What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("Hi. What is your marks in Physics? Please use value between 0-100");
            int markPhysics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hi. What is your marks in Chemistry? Please use value between 0-100");
            int markChemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hi. What is your marks in ComputerScience? Please use value between 0-100");
            int markComputerScience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Role No: " + roleNo);
            Console.WriteLine("Name of Student: " + studentName);
            Console.WriteLine("Marks in Physics: " + markPhysics);
            Console.WriteLine("Marks in Chemistry: " + markChemistry);
            Console.WriteLine("Marks in Computer Science: " + markComputerScience);
            Console.WriteLine("Your Total: " + (markChemistry+markComputerScience+markPhysics));
            Console.WriteLine("Percentage: " + (markChemistry + markComputerScience + markPhysics)*100/300 + "%");




            //Console.WriteLine("Role no {0}, student anem {1}", roleNo,studentName);

        }
    }
}
