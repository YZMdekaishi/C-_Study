using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stone stone = new Stone();
            stone.Age = 5000;
            Monkey wukongSun = (Monkey)stone;
            Console.WriteLine(wukongSun.Age);
        }
    }

    class Stone
    {
        public int Age;
        //把explicit换成implicit，就是隐式类型转换操作符，通过这段代码就解释了隐藏在类型转换背后的秘密
        public static explicit operator Monkey(Stone stone)
        {
            Monkey m = new Monkey();
            m.Age = stone.Age / 500;
            return m;
        }
    }

    class Monkey
    {
        public int Age;
    }
}
