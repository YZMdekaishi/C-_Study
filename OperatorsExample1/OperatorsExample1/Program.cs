using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorsExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Form myForm = new Form() {Text = "Hello" };
            var person = new { Name = "Mr.Okay", Age = 12, Score = 100};
            //是为匿名类型创建对象
            Console.WriteLine(person.Name);
            
            Console.WriteLine(person.GetType().Name);
            //在使用new操作符的时候要注意，类Program和Form类之间存在着紧密的依赖关系，如果Form出问题的话，
            //类Program也会出现异常，所以在使用时要小心
        }
    }
}
