using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            IWantSideEffect(ref y);
            Console.WriteLine("y={0},{1}",y,y.GetHashCode());
        }

        static void IWantSideEffect(ref int x)
        {
            x += 100;
            Console.WriteLine("x={0},{1}",x,x.GetHashCode());
        }
    }
}
