﻿using System;
using System.Windows.Forms;

namespace EventExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);
            form.ShowDialog();
        }
    }

    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            if (form != null)
            {
                this.form = form;
                this.form.Click += this.FormClicked;
            }
        }

        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
