using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //知识点1，隐式类型转换
            //Teach t = new Teach();
            //Human h = t;
            ////虽然h引用的实际对象是Teach类型，
            ////但编译器仅根据引用声明类型**​（Human）来验证成员访问权限。
            //Animal a = t;
            //虽然引用变量h引用了一个t,但是他只能访问该引用类型所能访问的成员
            //这些都是子类向父类进行的隐式类型转换

            //知识点2，显示类型转换
            Console.WriteLine(ushort.MaxValue);
            uint x = 65536;
            ushort y = (ushort)x;
            Console.WriteLine(y);
            
            
        }
    }
    //知识点1，隐式类型转换
    //class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Eating...");
    //    }
    //}

    //class Human : Animal
    //{
    //    public void Think()
    //    {
    //        Console.WriteLine("Who I am?");
    //    }
    //}

    //class Teach : Human
    //{
    //    public void Teach()
    //    {
    //        Console.WriteLine();
    //    }
    //}
}
