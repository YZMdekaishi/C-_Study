using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WASPEC.WebsiteURL);
        }
    }

    class WASPEC
    {
        public const string WebsiteURL = "http://www.waspec.org";
        //public static readonly Building Location = new Building(){ Address = "Some Address" };-Yes
        //public static readonly Building Location = new Building("Some Address");-Yes
        //public const Building Location = new Building("Some Address");-No
        //public const Building Location = new Building() { Address = "Some Address" };-No
    }

    class Building
    {
        public Building(string address)
        {
            this.Address = address;
        }
        
        public string Address { get; set; }
    }
}
