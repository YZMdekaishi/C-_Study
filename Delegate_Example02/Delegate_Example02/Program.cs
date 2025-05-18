using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example02
{
    delegate double Function(double x);

    class Multiplier
    {
        double factor;
        public Multiplier(double factor)
        {
            this.factor = factor;
        }

        public double Multiply(double x)
        {
            return x * factor;
        }
    }
    class Test
    {
        public static double Square(double x)
        {
            return x * x;
        }
        public static double[] Apply(double[] a, Function f)
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = f(a[i]); 
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 0.0, 0.5, 1.0 };
            double[] squares = Test.Apply(a, Test.Square);
            Console.WriteLine("squares:");
            foreach (var item in squares)
            {
                Console.WriteLine(item);
            }
            
            double[] sines = Test.Apply(a, Math.Sin);

            Console.WriteLine("sinces:");
            foreach (var item in sines)
            {
                Console.WriteLine(item);
            }
            Multiplier m = new Multiplier(2.0);
            double[] doubles = Test.Apply(a, m.Multiply);

            Console.WriteLine("doubles:");
            foreach (var item in doubles)
            {
                Console.WriteLine(item);
            }
        }
    }
}
