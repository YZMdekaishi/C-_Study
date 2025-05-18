using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorPiority
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator ca = new Calculator();
            Action myAction = new Action(ca.PrintHello);
            //这个是属于委托，通过myAction引用变量间接调用ca的方法
            myAction();
        }
    }

    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
