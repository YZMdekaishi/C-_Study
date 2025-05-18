using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExample2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Student
    {
        public void Report()
        {
            Console.WriteLine("I'm a student");
        }
    }

    class CsStudent
    {
        new public void Report()//这个new在这里是起到了一个修饰符的作用
            //子类隐藏父类的方法，在编程中不是很常用 
        {
            Console.WriteLine("I'm a CsStudent");
        }
    }
}
