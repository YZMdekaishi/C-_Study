using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexExample00
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu["Math"] = 100;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore == null);
        }
    }

    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();

        public int? this[string subject]//indexer+Tab+Tab,可以调出这个索引器
        {
            get {
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set {
                if (value.HasValue == false)
                {
                    throw new Exception("Score cannot be null");
                }

                if (this.scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;
                }
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
}
