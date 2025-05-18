using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Caculator cal = new Caculator();
            try
            {
                result = cal.Add("999999999999999999999", "10");
            }
            catch (OverflowException oe)
            {

                Console.WriteLine(oe.Message);
            }
            Console.WriteLine(result);
        }
    }
    class Caculator
    {
        public int Add(string arg1, string arg2){
            int a = 0;
            int b = 0;
            bool hasError = false;
            try//解析这条语句可能会出现的异常
            {
                a = Int32.Parse(arg1);
                b = Int32.Parse(arg2);
            }
            catch (ArgumentNullException Ane)//异常情况1
            {
                Console.WriteLine(Ane.Message);
                hasError = true;
            }
            catch (FormatException Fe)//异常情况2
            {
                Console.WriteLine(Fe.Message);
                hasError = true;
            }
            catch (OverflowException Oe)//异常情况3
            {
                throw;//把异常抛出去，抛到调用该方法的字段中去
            }
            finally//这条语句是无论如何都会被执行
            {
                if (hasError)
                {
                    Console.WriteLine("Execution is Error");
                }
                else
                {
                    Console.WriteLine("Done!");
                }
            }
            int result = a + b;
            return result;
        }
    }
}
