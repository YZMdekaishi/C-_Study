using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample03
{
    class Program
    {
        static void Main(string[] args)
        {
            //事件的拥有者同时也是事件的响应者
            MyForm form = new MyForm();
            form.Click += form.FormCliked;

            form.ShowDialog();
        }
    }

    class MyForm: Form
    {

        internal void FormCliked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
