using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Console.WriteLine(stu.ID);
            Console.WriteLine(stu.Name == null);

        }
    }

    class Student
    {
        //构造器
        /*
        public Student()
        {
            this.ID = 0;
            this.Name = "No Name";
        }*/
        //public Student(int initID,string initName)
        //{
        //    this.ID = initID;
        //    this.Name = initName;
        //}

        //public Student()
        //{
        //    this.ID = 1;
        //    this.Name = "Mr.Okay";
        //}
        public int ID;
        public string Name;
    }
}
