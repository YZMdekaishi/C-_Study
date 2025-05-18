using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample07
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myIntArray = new int[] { 1, 2, 3 };
            int result = CalculateSum(myIntArray);

            int new_result = new_CalculateSum(1, 2, 3, 4, 5);
            Console.WriteLine(new_result);

            //通过对比下面这两个方法，可以看出，new_CalculateSum该方法
            //可以通过直接传参数的值，没必要初始化整形数组就能计算出总和，
            Console.WriteLine(result);

            string str = "Tim,Tom.Honey.";
            string[] str_Array = str.Split(',','.','.');

            foreach (var item in str_Array)
            {
                Console.WriteLine(item);
            }
        }

        static int CalculateSum(int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }

            return sum;
        }

        static int new_CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }

            return sum;
        }
    }
}
