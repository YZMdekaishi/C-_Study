using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ModbusDemo
{
    public partial class FormModbus : Form
    {
        public FormModbus()
        {
            InitializeComponent();
        }
        Modbus objMod = new Modbus();

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (objMod.OpenMyComm(9600, "COM3", 8, Parity.None, StopBits.One) == true) {
                MessageBox.Show("打开串口成功");
            }
            else
            {
                MessageBox.Show("打开串口失败");
            }
        }

        private void btn_ReadReg_Click(object sender, EventArgs e)
        {
            byte[] Res = objMod.ReadKeepReg(1, 0, 10);
            if (Res != null && Res.Length > 0)
            {
                this.listBox1.Items.Clear();
                for (int i = 0; i < Res.Length; i++)
                {
                    this.listBox1.Items.Add(Res[i].ToString());
                }
            }
        }
    }
}
