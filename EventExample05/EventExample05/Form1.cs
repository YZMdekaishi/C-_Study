using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.button3.Click += new EventHandler(this.ButtonClicked);挂接方式一
            //this.button3.Click += delegate(object sender, EventArgs e)
            //{
            //    this.myTextBox.Text = "haha!";
            //};比较古老的挂接方式二

            this.button3.Click += (object sender, EventArgs e)=>{
                this.myTextBox.Text = "Hoho!";
            };//这个是现在比较流行的写法

        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            if (sender == this.button1)
            {
                this.myTextBox.Text = "Hello";
            }

            if (sender == this.button2)
            {
                this.myTextBox.Text = "World!";
            }

            if (sender == this.button3)
            {
                this.myTextBox.Text = "Mr.Okay!";
            }
        }
    }
}
