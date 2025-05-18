using System;


namespace Override_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.Run();

        }
    }

    class Vehicle
    {
        private int _speed;
        public virtual int Speed { get { return _speed; } set {_speed = value;} }
        public /*virtual*/ virtual void Run()
        {
            Console.WriteLine("I'm running!");
            _speed = 100;
        }
    }

    class Car : Vehicle
    {
        private int _rpm;

        public override int Speed { get { return _rpm/100; } set {_rpm = value*100 ;} }

        public /*override*/ override void Run()
        {
            Console.WriteLine("Car is running!");
            _rpm = 5000;
        }
    }

    class RaceCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("Race car is running！");
        }
    }
}
