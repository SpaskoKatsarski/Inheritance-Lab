using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Student : Person
    {
        public Student(string studentName, string school) : base(studentName)
        {
            School = school;
        }

        public Student(int studentAge) : base(studentAge)
        {

        }

        public Student(string name, int age) : base(name, age)
        {

        }
        public string School { get; set; }
    }
}
