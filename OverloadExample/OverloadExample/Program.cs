using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Caculator cal = new Caculator();
            Console.WriteLine(cal.Add(1, 2));
        }
    }

    class Caculator
    {
       
        public int Add(int a, int b)
        {
            a = 100;
            return a + b;
        }
    }
}
