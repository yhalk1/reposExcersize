using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClasses
{
    abstract class Vehicle
    {
        public int ageVehicle;
        public string madeVehicle;

        public virtual void StartEngine() { }
        public virtual void StopEngine() { }

       public Vehicle() { }

        public Vehicle(int age, string made)
        {
            ageVehicle = age;
            madeVehicle = made;
        }
                
    }
}
