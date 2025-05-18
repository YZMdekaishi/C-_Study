using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMemberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(1);
            Console.WriteLine(stu1.ID);
            

        }
    }

    class Student
    {
        public readonly int ID;//对于只读字段而言，只能在构造器中给他赋值

        public Student(int id)
        {
            this.ID = id;
        }

    }

    struct Color//结构体的静态只读字段
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    class Brush
    {
        //public static readonly Color DefaultColor = new Color() { Red = 0, Green = 0, Blue = 0 };
        public static readonly Color DefalutColor;
        static Brush(){
            Brush.DefalutColor = new Color() { Red = 0, Green = 0, Blue = 0 };
    }
    }
}
