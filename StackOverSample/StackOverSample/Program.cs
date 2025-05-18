using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //BadGuy bg = new BadGuy();
            //bg.BadMethod();

            unsafe
            {
                int *p = stackalloc int[9999999];
            } 
        }
    }
    /// <summary>
    /// 这个例子是关于栈溢出
    /// </summary>
    //class BadGuy
    //{
    //    public void BadMethod()
    //    {
    //        int x = 100;
    //        this.BadMethod();
    //    }
    //}
}
