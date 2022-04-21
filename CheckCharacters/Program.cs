using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide two characters:");
            
            var char1 = Char.Parse(Console.ReadLine());
            var char2 = Char.Parse(Console.ReadLine());
            
            if ((Char.IsUpper(char1) && Char.IsUpper(char2)) || (Char.IsLower(char1) && Char.IsLower(char2)))
                Console.WriteLine(1);
            else if ((Char.IsLetter(char1) && Char.IsLetter(char2)) && !(Char.IsLower(char1) && Char.IsLower(char2)))
                Console.WriteLine(0);
            else if (!Char.IsLetter(char1) && !Char.IsLetter(char2))
                Console.WriteLine(-1);
            else
                Console.WriteLine("One of chars is letter");
        }
    }
}
