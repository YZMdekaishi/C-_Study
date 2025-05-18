using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int* p = stackalloc int[99999999];
            }
        }
    }
}
