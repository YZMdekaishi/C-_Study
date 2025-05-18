using System;
using System.Collections;

namespace IspExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList{ 1, 2, 3, 4, 5 };

            Console.WriteLine("nums1 = {0}",Sum(nums1));
            Console.WriteLine("nums2 = {0}",Sum(nums2));

            var nums3 = new ReadOnlyCollection(nums1);
            Console.WriteLine("nums3 = {0}",Sum(nums3));
        }

        static double Sum(IEnumerable nums)
        {
            double  result = 0;
            foreach (var num in nums)
            {
                result += (int)num;
            }
            return result;
        }

        static double Avg(ICollection nums)
        {
            double result = 0;
            double sum = 0;
            int count = 0;
            foreach (var num in nums)
            {
                sum += (int)num;
                count++;
            }
            result = sum/count;
            return result;
        }


        class ReadOnlyCollection : IEnumerable
        {
            private int[] _array;

            public ReadOnlyCollection(int[] array)
            {
                _array = array;
            }

            public IEnumerator GetEnumerator()//这里的意思是当外界迭代ReadOnly...类时，你要给他一个迭代器IEnumerator
            {
                return new Enumerator(this);
            }

            public class Enumerator : IEnumerator//该类是个成员类，全名是ReadOnlyCollection.Enumerator
            {
                private ReadOnlyCollection _collection;
                private int _head;

                public Enumerator(ReadOnlyCollection collection)
                {
                    _collection = collection;
                    _head = -1;
                }
                public object Current
                {
                    get { object o = _collection._array[_head]; return o; }
                }

                public bool MoveNext()
                {
                    if (++_head < _collection._array.Length)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                public void Reset()
                {
                    _head = -1;
                }
            }
        }
    }
}
