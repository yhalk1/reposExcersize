using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dev = new Programmer();
            var builder = new Builder();

            var iDevArray = new List<IDeveloper> { dev, builder };
            // TODO
            // IDesposible  using despose ?

            foreach (var developer in iDevArray)
            {
                developer.Create();
                developer.Destroy();
                developer.Tool = "hello " + " qwe";
                Console.WriteLine(developer.Tool);
            }
        }
    }

    public interface IDeveloper
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }




}
