using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new PhoneUser(new XiaoMi());
            user.Functions();
            Console.WriteLine("==============");

            var user2 = new PhoneUser(new RedMi());
            user2.Functions();
            /*该程序成功的解决了紧耦合的问题*/

        }
    }

    class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }
        public void Functions()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.Receive();
            _phone.Send();
        }
    }

    interface IPhone
    {
        void Dail();
        void PickUp();
        void Send();
        void Receive();
    }

    class XiaoMi : IPhone
    {

        public void Dail()
        {
            Console.WriteLine("XiaoMi Calling ...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Tim!");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
        public void Receive()
        {
            Console.WriteLine("XiaoMi message ring...");
        
        }
    }

    class RedMi : IPhone
    {

        public void Dail()
        {
            Console.WriteLine("RedMi calling");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Tim");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }

        public void Receive()
        {
            Console.WriteLine("RedMi! ring ...");
        }
    }
}
