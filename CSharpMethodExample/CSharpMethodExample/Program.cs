using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator ca = new Calculator();
            Console.WriteLine(Calculator.GetConeVolume(3,12));
        }
    }

    class Calculator
    {
        public static double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }
        public static double GetCylinderVolume(double r, double h)
        {
            double a = GetCircleArea(r);
            return a * h;
        }
        public static double GetConeVolume(double r, double h)
        {
            double cv = GetCylinderVolume(r, h);
            return cv / 3;
        }
    }
}
