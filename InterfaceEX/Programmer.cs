using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEX
{
    public class Programmer : IDeveloper
    {
        public string Language;

        public string Tool { get; set; }

        public void Create()
        {
            Console.WriteLine("Programmer created something great)))");
        }
        public void Destroy()
        {
            Console.WriteLine("Programmer destroyed his or her creation(((");
        }

    }
}
