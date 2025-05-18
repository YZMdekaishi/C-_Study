using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace The_access_level_class_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            v1.Owner_public = "Timothoy";
            Console.WriteLine(v1.Owner_public);
            //Console.WriteLine(v1.Owner_internal);

            Car car = new Car();
            car.TurboAccelerate();
            Console.WriteLine(car.Speed);

            Bus bus = new Bus();
            bus.SlowAccelerate();
            Console.WriteLine(bus.Speed);
        }
    }

    class Bus : Vehicle
    {
        public void SlowAccelerate() 
        {
            Burn(1);
            _rpm += 500;
        
        
        }
    }
}
