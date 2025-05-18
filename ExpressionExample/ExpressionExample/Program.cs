using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Form myForm = new Form();
            //myForm.Text = "Hello";
            //myForm.Load += myForm_Load;
            //myForm.ShowDialog();

            List<int> intList = new List<int>() { 1, 2, 3 };
            int x = intList[2];
            Console.WriteLine(x);

        }

        static void myForm_Load(object sender, EventArgs e)//这个是个事件处理器
        {
            Form form = sender as Form;
            if (form == null)
            {
                return;
            }
            form.Text = "New Title";
        }
    }
}
