using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public Person(int age)
        {
            Age = age;
        }

        public Person(string name, int age)
        {

        }

        public string Name { get; set; }

        public int Age { get; set; }

        public void WriteName()
        {
            Console.WriteLine(Name);
        }

        public void WriteAge()
        {
            Console.WriteLine(Age);
        }
    }
}
