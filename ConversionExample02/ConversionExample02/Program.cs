using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcd";
            string str2 = "abdc";
            Console.WriteLine(string.Compare(str1, str2));
        }
    }
}
