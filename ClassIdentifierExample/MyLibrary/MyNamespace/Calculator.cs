using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.MyNamespace
{
    public class Calculator//这里看似什么都没加，其实前面有个internal
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
