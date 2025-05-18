using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //double result = GetCyclinderVolume(10, 100);
            //Console.WriteLine(result);
            const int a = 100;
            
            string input = Console.ReadLine();
            try
            {
                double score = double.Parse(input);
                if (score >= 60)
                {
                    Console.WriteLine("Pass!");
                }
                else
                {
                    Console.WriteLine("Faild！");
                }
            }
            catch 
            {

                Console.WriteLine("Please input a number!!");
            }

        }

        public static double GetCyclinderVolume(double r, double h)
        {
            double area = 3.1416 * r * r;
            double volume = area * h;
            return volume;
        }
    }
}
