using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student.Amount = -100;
                Console.WriteLine(Student.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Student
    {
        private int age;//可以用快捷键propfull，prop是property的缩写

        public int Age
        {
            get { return age; }
            set 
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age value has error.");
                }
            }
        }

        private static int amount;
                
        public static int Amount
        {
            get { return amount; }
            set 
            {
                if (value >= 0)
                {
                    amount = value;
                }
                else
                {
                    throw new Exception("Amount value has error.");
                }
            }
        }
        //这段代码可以使用ctrl+e+r键，来进行字段的封装。 
        //private int score;

        //public int Score
        //{
        //    get { return score; }
        //    set { score = value; }
        //}

        public int score { get; set; }
        
    }
}
