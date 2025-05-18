using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int score = 0;
            do
            {
                Console.WriteLine("Please input first number:");
                string str1 = Console.ReadLine();
                int x = 0;
                try
                {
                    x = Int32.Parse(str1);
                }
                catch
                {
                    Console.WriteLine("The firts number has problem!");
                    continue;
                }

                Console.WriteLine("Please input second number:");
                string str2 = Console.ReadLine();
                int y = 0;
                try
                {
                    y = Int32.Parse(str2);
                }
                catch
                {
                    Console.WriteLine("The second number has problem!");
                    continue;
                }

                sum = x +y;
                if(sum == 100){
                    score++;
                    Console.WriteLine("Correct!{0}+{1}={2}",x,y,sum);
                }else{
                    Console.WriteLine("Error!{0}+{1}={2}",x,y,sum);
                }
                
            } while (sum==100);

            Console.WriteLine("Your score is {0}.",score);
            Console.WriteLine("GAME OVER!");
        }
    }
}
