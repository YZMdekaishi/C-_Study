using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass{
    class Program{
        static void Main(string[] args){
            //知识点一：                                                                                                
            //Student stu1 = new Student(1, "Timothy");
            //stu1.Report();

            //Type t = typeof(Student);
            //object o = Activator.CreateInstance(t, 1, "Timothy");
            ////上面两段代码是关于反射的写法，这里主要是为了展现反射关于类的类型的一面

            //dynamic stu = Activator.CreateInstance(t, 1, "Timothy");
            //Console.WriteLine(stu.Name);
            ////Console.WriteLine(o is Student);//答案是True
            ////Console.WriteLine(o.GetType().Name);//返回Student
            ////Student stu = (Student)o;
            ////Console.WriteLine(stu.Name);
            ////Console.WriteLine(stu.ID);

            //知识点二：
            Student stu1 = new Student(1, "Timothy");
            Student stu2 = new Student(2, "Jacky");
            Console.WriteLine(Student.Amount);

        }
    }

   
    class Student
    {
        public static int Amount { get; set; }//一般使用静态属性，都是对类有意义的，这里是用于统计创建了多少个Student实例
        static Student()//这个是静态构造器,注意：静态构造器只能构造静态成员
        {
            Amount = 100;
        }

        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            Student.Amount++;//这里是每创造一个Student实例，就++一个Amount;
        }

        ~Student()
        {
            Amount--;//当这个实例没了，就让Amount--;
        }

        //~Student()//析构器(析构函数）的写法
        //{
        //    Console.WriteLine("Bye bye!Release the system resources ...");
        //}

        public int ID { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            Console.WriteLine("I'm #{0} student, my name is {1}.", this.ID, this.Name);

        }
    }
}
