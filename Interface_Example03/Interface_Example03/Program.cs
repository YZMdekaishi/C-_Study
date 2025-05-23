﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new PhoneUser(new NokiaPhone());
            user.UserPhone();

            Console.WriteLine("======================");
            var user1 = new PhoneUser(new EricssonPhone());
            user1.UserPhone();

        }
    }

    class PhoneUser
    {
        private IPhone _phone;

        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }

        public void UserPhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.Send();
            _phone.Receive();

        }
    }

    interface IPhone
    {
        void Dail();
        void PickUp();
        void Receive();
        void Send();
        

    }

    class NokiaPhone:IPhone
    {

        public void Dail()
        {
            Console.WriteLine("Nokia calling ...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia message ring...");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
    }

    class EricssonPhone : IPhone
    {

        public void Dail()
        {
            Console.WriteLine("Ericsson calling ...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hi!This's Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Ericsson ring ...");
        }

        public void Send()
        {
            Console.WriteLine("Good evening!");
        }
    }
}
