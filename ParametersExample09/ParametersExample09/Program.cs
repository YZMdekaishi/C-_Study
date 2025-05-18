using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample09
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14159;
            double y = Math.Round(x, 4);//对x取小数点后四位

            //扩展方法（this参数）
            //方法必须是公有的，静态的，即被public static所修饰
            //必须是形参列表中的第一个，由this修饰
            //必须由一个静态类（一般类名为SomeTypeExtension)来统一收纳对
            //SomeType类型的扩展方法
            double y2 = x.Round(4);
            Console.WriteLine(y);
        }
    }

    static class DoubleExtension
    {
        public static double Round(this double input, int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }
}
