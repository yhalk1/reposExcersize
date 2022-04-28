using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Accent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide whatsapp message");

            string[] hello = { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" }; //greetings
            string[] accent = { "english", "italian", "french", "german", "spanish", "czech", "polish" }; //languages
            var helloLenght = hello.Length;
            var char1 = Console.ReadLine().ToLower(); //invalid name, please rename

            for (int i = 0; i < helloLenght; i++)
            {
                if (char1.Contains(hello[i]))
                    Console.WriteLine("It's an {0} accent", accent[i]);
            }
        }
    }
}
