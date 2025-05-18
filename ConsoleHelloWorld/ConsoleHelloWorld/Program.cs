
using System;
using Tools;
using System.Windows.Forms;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            double result = Calculater.Div(13.5, 0);
            Console.WriteLine(result);
            Console.WriteLine("Hello");
        }
    }
}
