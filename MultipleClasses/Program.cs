using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Vehicle mini = new MiniVan(10, "Dodge", 7);
            MiniVan mini = new MiniVan(12,"GMC", 9);
            mini.Qwerty = 123;
            Vehicle tractor = new Tractor(20, "New Holland", 240);

            Vehicle[] vehicles = new[] { mini, tractor };

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"The vehicle age is {vehicle.ageVehicle} and vehicle made is {vehicle.madeVehicle}");
                vehicle.StartEngine();
                vehicle.StopEngine();
                if (vehicle is MiniVan)
                {
                    Console.WriteLine("This is MiniVan");
                }

                var car = (vehicle as MiniVan) ?? mini;
              
            }
        }
    }
}
