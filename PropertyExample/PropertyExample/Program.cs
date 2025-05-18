using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student stu1 = new Student();
                stu1.Age = 20;

                Student stu2 = new Student();
                stu2.Age = 20;

                Student stu3 = new Student();
                stu3.Age = 20;

                int AvgAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
                Console.WriteLine(AvgAge);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            
        }
    }

    class Student
    {
        private int age;//私有的字段

        public int Age
        //包装器,这个例子一定要记下来，以后肯定用的上
        //公共的属性，Age这个属性是age字段的包装器
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age value has error!");
                }
            }
        }

        //public int GetAge()
        //{
        //    return this.age;
        //}

        //public void SetAge(int Value) {
        //    if (Value > 0 && Value < 120)
        //    {
        //        this.age = Value;
        //    }
        //    else
        //    {
        //        throw new Exception("Age Value is Error!");
        //    }
        //}
    }
}
