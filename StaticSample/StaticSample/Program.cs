﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Form forms = new Form();
            forms.Text = "Hello";
            forms.ShowDialog();
        }
    }
}
