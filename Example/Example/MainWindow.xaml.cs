using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.myButton.Click += myButton_Click;
            //这个是使用方法调用

            //this.myButton.Click += delegate(object sender, RoutedEventArgs e)
            //{
            //    this.myTextBox.Text = "Hello World";
            //};//这个使用delegate修饰符来调用方法，只不过现在用的比较少了
            this.myButton.Click += (object sender, RoutedEventArgs e)=>
            {
                this.myTextBox.Text = "Hello World";
            };//比较常用的是使用拉姆达表达式

        }
        //void myButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.myTextBox.Text = "Hello World";
        //}

    }
}
