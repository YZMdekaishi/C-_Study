using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.MyNamespace;

namespace ClassIdentifierExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            double a = 1, b = 2;
            double result = cal.Add(a, b);
            Console.WriteLine("result = {0}.",result);
        }
    }
}
