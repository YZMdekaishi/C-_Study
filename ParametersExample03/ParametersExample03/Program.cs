using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample03
{
    class Program
    {
        static void Main(string[] args)
        {
            //知识点一：引用参数的引用实例
            Student stu = new Student() { Name = "Tim" };
            Console.WriteLine("HashCode={0},Name={1}",stu.GetHashCode(),stu.Name);
            Console.WriteLine("=======================");
            IWanSideEffect(ref stu);
            Console.WriteLine("HashCode={0},Name={1}", stu.GetHashCode(), stu.Name);

        }

        static void IWanSideEffect(ref Student stu)//引用参数的引用实例
        {
            stu = new Student() { Name = "Tom" };
            Console.WriteLine("HashCode={0},Name={1}",stu.GetHashCode(),stu.Name);
        }
    }
    //知识点一：引用参数的引用实例
    /*
    class Student
    {
        public string Name { get; set; }
    }
    */
    //知识点2：
    class Student
    {
        public string Name { get; set; }
    }
}
