using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(null);
            Console.WriteLine(stu.name);
        }
    }
    class Student
    {
        public Student(string initName)
        {
            if (!string.IsNullOrEmpty(initName))
            {
                this.name = initName;
            }
            else
            {
                throw new ArgumentException("initName cannot be null or empty");
            }
        }

        public string name;
    }
}
