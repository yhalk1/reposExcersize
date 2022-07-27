using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClasses
{
    internal class MiniVan : Vehicle
    {
        public int NumberOfSeats;
        private int qwerty;

        public int Qwerty
        {
           get { return qwerty; }
           set { qwerty = value; }
        }
        

        public MiniVan() { }

        public MiniVan(int age, string made, int NumberSeats) : base (age, made)
        {
            NumberOfSeats = NumberSeats;  
        }

        public override void StartEngine()
        {
            Console.WriteLine("The minivan engine is started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("The minivan engine is stopped");
        }
        
    }
}
