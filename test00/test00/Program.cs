﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test00
{
    public delegate double Calc(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Calc calc1 = new Calc(calculator.Add);
            Calc calc2 = new Calc(calculator.Sub);
            Calc calc3 = new Calc(calculator.Div);
            Calc calc4 = new Calc(calculator.Mul);

        }
    }

    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }
    }
}
