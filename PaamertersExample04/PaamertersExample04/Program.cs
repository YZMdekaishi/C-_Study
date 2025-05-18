using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaamertersExample04
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { Name = "Tim" };
            Console.WriteLine("HashCode={0}，Name={1}",stu.GetHashCode(),stu.Name);

            Console.WriteLine("==========================");
            SomeSideEffect(ref stu);
            Console.WriteLine("HashCode={0},Name={1}",stu.GetHashCode(),stu.Name);
        }

        static void SomeSideEffect(ref Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine("HashCode ={0},Name= {1}",stu.GetHashCode(),stu.Name);
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}
