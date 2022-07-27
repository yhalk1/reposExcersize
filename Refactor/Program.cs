using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Katana katana = new Katana(new Active());
            
            Console.WriteLine(katana.GetStatusDescription());
        }
    }
}
