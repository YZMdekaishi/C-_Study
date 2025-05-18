using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student stu = new Student();
                stu.Age = 20;
                Console.WriteLine(stu.CanWork);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }

    class Student
    {

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value;
            this.CalcumateCanWork();
            }
        }


        /*public bool CanWork
        {
            get
            {
                if (this.age >= 16)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }*/

        private bool canWork;

        public bool CanWork
        {
            get { return canWork; }   
        }

        public void CalcumateCanWork()
        {
            if (this.age >= 16)
            {
                this.canWork = true;
            }
            else
            {
                this.canWork = false;
            }
        }
        
    }
}
