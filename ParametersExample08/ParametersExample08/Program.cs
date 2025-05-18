using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample08
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo(name:"Tim",age:12);//这个是具名参数的调用，参数的位置不再受约束
            PrintInfo(age: 12,name: "Tim");

            PrintInfo("Tim", 12);//使用具名参数的优点，可以更好的看出Tim和age的值

            //知识点二，可选参数
            //参数因为具有默认值而变得“可选”，不推荐使用可选参数
            //参数为什么可选呢？是因为在声明时，具有默认值
            PrintInfo();
        }

        static void PrintInfo(string name="Tim", int age = 32)
        {
            Console.WriteLine("Hello {0},you are {1}",name,age);
        }
    }
}
