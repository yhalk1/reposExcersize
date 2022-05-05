using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = 5;
            int[] numbersArray = new int[arrayLenght];
            
            Console.WriteLine("Please provide a number:  ");
            
            for (int i = 0; i < arrayLenght; i++)
            {
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //SelectMaxEvenNumber(numbersArray);
            int j = SelectMaxEvenNumber(numbersArray);
            Console.WriteLine("The max even number is: " + j);
        }
        public static int SelectMaxEvenNumber(int[] array)
        {
            //Array.Sort(array);
            var maxValue = 0;
            foreach (int number in array )
            {
                if (number % 2 == 0 && number > maxValue)
                {
                    maxValue = number; 

                    //Console.WriteLine("The max even number is: ");
                }
            }
            return maxValue;
        }
    }
}
