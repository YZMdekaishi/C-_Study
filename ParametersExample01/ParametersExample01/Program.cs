using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample01
{
    class Program
    {//面试可能会考到，为什么两个打印出来的值不一样？

        static void Main(string[] args)
        {
            Student oldStu = new Student() { Name = "Tim" };
            SomeMethod(oldStu);
            Console.WriteLine("{0},{1}", oldStu.GetHashCode(), oldStu.Name);
        }


        static void SomeMethod(Student stu)
        {
            stu = new Student() { Name = "Tom" };
            Console.WriteLine("{0},{1}",stu.GetHashCode(),stu.Name);
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}
