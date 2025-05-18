using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type t = typeof(Car);
            //Type t1 = typeof(Vehicle);
            //Type tb1 = t1.BaseType;
            //Console.WriteLine(tb1.FullName);
            //Type tb = t.BaseType;
            //Console.WriteLine(tb.FullName);
            ////这段程序用于证明Car的父类是Vehicle
            //Vehicle vehicle = new Vehicle();
            //Car car = new Car();

            //Console.WriteLine(car is Vehicle);
            ////这段程序可以引用出一个定义：父类类型的变量可以引用一个子类类型的实例
            //Vehicle vehicle1 = new Car();
            //object o1 = new Car();
            //object o2 = new Vehicle();

            //知识点三：
            //RaceCar raceCar = new RaceCar();
            //raceCar.ShowOwner();


            Car car = new Car("Timothy");
            Console.WriteLine(car.Owner);
        }
    }

    class Vehicle//在class 前面引用一个sealed修饰符后，意思是该类被封闭了，不允许再进行继承操作了
    {
        public Vehicle(string owner)
        {
            this.Owner = owner;
        }
         public string Owner { get; set; }
    }

    class Car:Vehicle
    {
        //问题一：当父类构造器中添加了参数时，子类构造器应该如何修改呢？
        //方法一：在子类构造器中，放入“N/A”到父类构造器中
        //public Car():base("N/A")
        //{
        //    this.Owner = "Car Owner";
        //}

        public Car(string owner):base(owner)
        {
            this.Owner = owner;
        }
        public void ShowOwner()
        {
            Console.WriteLine(base.Owner);//这里需要学习一下base关键字，注意base关键字只能访问上一级父类的属性,不能这样写base.base.Owner
        }
    }

}
