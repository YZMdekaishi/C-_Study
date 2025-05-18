using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample04
{
    class Program
    {
        static void Main(string[] args)
        {
            Myform form = new Myform();
            form.ShowDialog();
        }
    }

    class Myform : Form
    {
        private TextBox textBox;
        private Button button;//事件的拥有者

        public Myform()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.button.Click += this.buttonClicked;//事件是button.Click
            this.button.Text = "Say Hello";
            this.button.Top = 15;
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello,World!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
        }
       
    }
}
