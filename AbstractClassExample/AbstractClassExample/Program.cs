using System;


namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle c = new Car();
            c.Run();
            c.Stop();
            c.Fill();
            Console.WriteLine("==================");
            Vehicle t = new Truck();
            t.Run();
            t.Stop();
            t.Fill();
            Console.WriteLine("===================");
            RaceCar r = new RaceCar();
            r.Run();
            r.Stop();
            r.Fill();
        }
    }

    //abstract class VehicleBase
    //{
    //    abstract public void Stop();
    //    abstract public void Fill();
    //    abstract public void Run();
    //}/*上面这个纯抽象类在C++语言中用的比较多，一般在Java和C#语言中实际就是接口*/
    interface/*这里省略了public*/ IVehicle//interface这个修饰符要求里面所有的成员都必须是public的
        //接口本身就包括了他所有的成员一定都是抽象的,即可以省略abstract public
    {//接口
        /*abstract public*/ void Stop();
        /*abstract public*/ void Fill();
        /*abstract public*/ void Run();
    }
   abstract class Vehicle:IVehicle
    {//抽象类
        public void Stop()
        {
            Console.WriteLine("Stopped!");
        }
        //public virtual void Run()
        //{
        //    Console.WriteLine("Vehicle is running...");
        //}
        public  void Fill()
        {
            Console.WriteLine("Pay and fill...");
        }

        abstract public void Run();
    }

    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }

    class Truck: Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }

    class RaceCar : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Race car is running...");
        }
    }
}
