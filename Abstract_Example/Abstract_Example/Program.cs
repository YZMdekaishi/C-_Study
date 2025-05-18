using System;

namespace Abstract_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Truck();
            Vehicle v2 = new Car();
            IVehicle v3 = new Truck();
            v3.Run();
            v1.Run();
            v2.Run();

        }
    }

    interface IVehicle
    {
        void Run();
        void Fill();
        void Stop();
    }

    abstract class Vehicle : IVehicle
    {
        public void Fill()
        {
            Console.WriteLine("Pay is filling...");
        }
        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
        abstract public void Run();
    }

    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running");
        }
    }
    class Truck : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running");
        }
    }

}
