using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            Human hu = new Human();
            Teach tea = new Teach();
            Car ca = new Car();

            Animal ani1 = hu as Animal;//这里理解为如果hu像Ainmal的话，就把Animal类的地址给anil,否则会给Null
            ani1.Eat();

            Human hu1 = ani as Human;
            if (hu1 == null)
            {
                Console.WriteLine("Hello1");
            }
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("I'm eating");
        }
    }

    class Human:Animal
    {
        public void Think()
        {
            Console.WriteLine("Who I am?");
        }
    }
    class Teach : Human
    {
        public void teach()
        {
            Console.WriteLine("I'm teaching");
        }
    }

    class Car
    {
        public void driving()
        {
            Console.WriteLine("I'm driving");
        }
    }
}
