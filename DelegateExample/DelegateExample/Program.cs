using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Action action = new Action(calculator.Report);
            calculator.Report();

            action.Invoke();
            action();

            Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);

            int z = func1.Invoke(300, 200);
            z = func1(300, 200);
            Console.WriteLine(z);
            z = func2.Invoke(300, 200);
            z = func2(300, 200);
            Console.WriteLine(z);

            //Action委托和Func委托是C#语言中比较常用的委托，Func委托也叫泛型委托
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods.");
        }

        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int Sub(int a, int b)
        {
            int result = a - b;
            return result;
        }

    }
}
