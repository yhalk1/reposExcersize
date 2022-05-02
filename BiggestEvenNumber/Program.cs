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
            int[] numbersArray = new int[5];
            int arrayLenght = numbersArray.Length;

            Console.WriteLine("Please provide a number:  ");
            
            for (int i = 0; i < arrayLenght; i++)
            {
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            SelectMaxEvenNumber(numbersArray);
        }

        public static void SelectMaxEvenNumber(int[] array)
        {
            Array.Sort(array);
            for (int i = array.Length-1; i > 0 ; i--)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("The max even number is: " + array[i]);
                    break;
                }
            }
            
        }
        

    }
}
