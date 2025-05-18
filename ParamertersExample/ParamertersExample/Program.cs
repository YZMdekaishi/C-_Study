using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamertersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            int y = 100;
            stu.AddOne(y);//这个属于传值类型
            Console.WriteLine(y);//这里为什么打印出来是100，是因为22行
        }
    }

    class Student
    {
        public void AddOne(int x)//这个是传值参数，方法体内有一个形参，
            //这个形参不会影响方法体外的数据
        {
            x += 1;
            Console.WriteLine(x);
        }
    }
}
