using System;
using System.Collections;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };//提供方
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };//ArrayList是非泛型，后面的课程会进行学习
            //ArrayList中存储的类型是Object类型
            //提供方

            //查看int[]类型的父类Array和ArrayList都有IEnumerable接口，这意味着都是能被迭代的
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Avg(nums1));
            Console.WriteLine("=============");
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Avg(nums2));
        }

        static int Sum(IEnumerable nums)//需求方
        {
            int sum = 0;
            foreach (var n in nums)//需求方要求能迭代
            {
                sum += (int)n;
            }
            return sum;
        }

        static double Avg(IEnumerable nums)//需求方
        {
            int sum = 0;
            double count = 0;
            foreach (var n in nums)//需求方要求能迭代
            {
                sum += (int)n;
                count++;
            }
            return sum / count;
        }

      
    }

}
