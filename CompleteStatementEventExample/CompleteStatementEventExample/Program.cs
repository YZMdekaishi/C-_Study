using System;
using System.Threading;
using System.Threading.Tasks;

namespace CompleteStatementEventExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //这个是完整声明的案例
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();
        }
    }
    public class OrderEventArgs :EventArgs
	{
		public string DishName { get; set; }
        public string Size { get; set; }
	}

    public delegate void OrderEventHandler(Customer customer,OrderEventArgs e);//声明自定义委托
    public class Customer//事件的拥有者
    {
        private OrderEventHandler orderEventHandler;//委托字段_用于引用那些事件处理器的

        public event OrderEventHandler Order
        {
            add// 订阅事件时触发
            {
                this.orderEventHandler += value;// 将新处理器添加到委托链
            }

            remove// 取消订阅时触发
            {
                this.orderEventHandler -= value;// 从委托链移除处理器
            }
        }

        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine("I will pay ${0}.",this.Bill);
        }

        public void WalkIn()
        {
            Console.WriteLine("Walk into the restaurant.");
        }

        public void SitDown()
        {
            Console.WriteLine("Sit down.");
        }

        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think ...");
                Thread.Sleep(1000);
            }

            if (this.orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Kongpao Chicken";
                e.Size = "large";
                this.orderEventHandler.Invoke(this,e);
            }
        }

        public void Action()
        {

            Console.ReadLine();//这段代码功能是：程序要等我敲个回车才会执行之后的代码
            this.WalkIn();
            this.SitDown();
            this.Think();
        }
    }

    public class Waiter//事件的响应者
    {

        public void Action(Customer customer, OrderEventArgs e)//事件处理器
        {
            Console.WriteLine("I will serve you the dish .{0}.",e.DishName);
            double price = 10;
            switch (e.Size)
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price = price * 1.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }
    }
}
