using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//迭代器的使用的名称空间

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            //知识点一，集合遍历的底层原理和迭代器
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 ,7,8};
            IEnumerator enumerator = intArray.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine("====================");

            //foreach语句的最佳运用场合就是对集合进行遍历
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6 };
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
