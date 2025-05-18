using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persion1 = new Person();
            Person persion2 = new Person();
            persion1.name = "Deer";
            persion2.name = "Deer's wife";
            //List<Person> nation = Person.GetMarry(persion1, persion2);
            List<Person> nation = persion1 + persion2;
            foreach (var p in nation)
            {
                Console.WriteLine(p.name);
            }

        }
    }

    class Person
    {
        public string name;

        //public static List<Person> GetMarry(Person p1, Person p2)
        public static List<Person> operator +(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.name = p1.name + "&" + p2.name + "s child";
                people.Add(child);
            }
            return people;
        }
    }
}
