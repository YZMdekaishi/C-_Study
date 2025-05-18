using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(100);
            c.add2(1, 100);
        }
    }
    class Calculator
    {
        public void add2(int a, int b)
        {
            int result = 0;
            for (int i = a; i <= b; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
        public int Add(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                int result = x + Add(x - 1);
                return result;
            }
            
        }
    }
}
