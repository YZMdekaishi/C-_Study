using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first number.");
            string arg1 = Console.ReadLine();
            double x = 0;
            bool b1 = double.TryParse(arg1,out x);//这个是调用输出参数的实例
            if (b1 == false)
            {
                Console.WriteLine("Input error");
                return;//这段代码的作用可以直接退出程序。
            }

            Console.WriteLine("Please input second number.");
            string arg2 = Console.ReadLine();
            double y = 0;
            bool b2 = double.TryParse(arg2, out y);
            if (b2 == false)
            {
                Console.WriteLine("Input error");
                return;
            }

            double z = x + y;
            Console.WriteLine("{0}+{1}={2}",x,y,z);

            Console.WriteLine("=========================");
            double x1 = 100;
            bool b = DoubleParse.TryParse("7a9", out x1);
            if (b == true)
            {
                Console.WriteLine(x1+1);
            }
            else
            {
                Console.WriteLine(x1);
            }

        }
    }

    class DoubleParse
    {
        public static bool TryParse(string input, out double result)//输出参数在方法体里，必须要给他赋值 
        {//这里的double这个参数不要忽略，
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch
            {
                result = 0;//也就是这里不能省略
                return false;
            }
        }
    }
}
