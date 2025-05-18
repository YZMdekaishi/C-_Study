using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = Convert.ToInt32(Console.ReadLine());
            int grade = score / 10;
            switch (grade)
            {
                case 10:
                    if (score == 100)
                    {
                        goto case 8;
                    }
                    else
                    {
                        goto default;
                    }
                case 9:
                case 8:
                    Console.WriteLine("A");
                    break;
                case 7:
                case 6:
                    Console.WriteLine("B");
                    break;
                case 5:
                case 4:
                    Console.WriteLine("C");
                    break;
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("Input Error");
                    break;
            }

        }
    }
}
