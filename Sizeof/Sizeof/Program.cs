using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sizeof
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                //int x = sizeof(Student);//这里只要记住，可以用sizeof来计算结构体类型的大小就行
                //Console.WriteLine(x); 

                Student stu;
                stu.ID = 1;
                stu.Score = 99;
                Student* pStu = &stu;
                pStu->Score = 100;//地址间接访问操作符
                (*pStu).Score = 1000;//这里*pStu需要括起来，因为“.”的运算优先级大于*
                Console.WriteLine(stu.Score);
            }
        }
    }

    struct Student
    {
        public int ID;
        public long Score;
    }
}
