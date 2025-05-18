using System;
using System.Timers;

namespace EventExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();//事件的拥有者
            timer.Interval = 1000;
            Boy boy = new Boy();//事件的响应者
            Girl girl = new Girl();
            timer.Elapsed += girl.Action;
            timer.Elapsed += boy.Action;//事件是Elapsed，事件的订阅是“+=”操作符，事件处理器是boy.Action
            timer.Start();
            Console.ReadLine();
        }
    }

    class Boy
    {

        internal void Action(object sender, ElapsedEventArgs e)//事件处理器
        {
            Console.WriteLine("Jump!");
        }
    }

    class Girl
    {

        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
