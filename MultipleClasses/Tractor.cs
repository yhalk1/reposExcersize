using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClasses
{
    internal class Tractor : Vehicle
    {
        public int tractorPower;

        public Tractor(int age, string made, int power) : base (age,made)
        {
            tractorPower = power;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Dyr dyr engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Pur pur engine is broken");
        }
    }
}
