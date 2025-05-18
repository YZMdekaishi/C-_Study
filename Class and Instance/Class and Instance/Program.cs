using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_and_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Form()).Text = "Hlllow";
            (new Form()).ShowDialog();
            
        }
    }
}
