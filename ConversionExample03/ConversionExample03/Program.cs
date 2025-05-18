using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample03
{
    class Program
    {
        static void Main(string[] args)
        {
            //知识点1
            Nullable<int> x = null;//这个"Nullable"是个可空关键字
            int? y = null;//int？就是Nullable<int>
            int z = x ?? 1;//这里的意思是判断x是否为空值,如果为空值的话，就把1赋值给z
            Console.WriteLine("z=" + z);
            y = 100;
            Console.WriteLine(y);
            Console.WriteLine(x.HasValue);//HasValue是判断这个是否有数值
            x = 100;
            Console.WriteLine(x);
            Console.WriteLine(x.GetType().FullName);
            Console.WriteLine("======================");
            int x1 = 10;
            int x2 = 20;
            string str = x1 > x2 ? "Pass" : "Faild";
            int x3 = x1 > x2 ? 12 : 34;

        }
    }
}
