using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            var car = new Car(engine);
            car.Run(3);
            Console.WriteLine(car.Speed);
        }
    }

    class Engine
    {
        public int RPM { get;private set; }//这段代码的private是为了防止从外界进行修改转速
        public void Work(int gas)
        {
            this.RPM = 1000 * gas;
        }
    }

    class Car
    {
        private Engine _engine;
        public Car(Engine engine)
        {
            _engine = engine;
        }
        public int Speed { get;private set; }

        public void Run(int gas){
            _engine.Work(gas);
            this.Speed = _engine.RPM/100;
        }
    }
}
