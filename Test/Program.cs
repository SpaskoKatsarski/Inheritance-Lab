using System;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Vasko", "VII SU");
            st.WriteName();
            Console.WriteLine(st.School);

            Student st2 = new Student("Dimitrichko", "5SU");
            st2.WriteAge();

            Console.WriteLine($"Changing names of {st2.Name}");

            Stack stacky = new Stack();

            Console.WriteLine(stacky.Count);
            Console.WriteLine(stacky.IsEmpty());
            stacky.AddRange(new string[] { "dasdsa", "dadsadsa" });
            Console.WriteLine(stacky);
            Console.WriteLine(stacky.IsEmpty());
            Console.WriteLine(stacky.Count);
        }

        class Stack : Stack<string>
        {
            public bool IsEmpty()
            {
                return base.Count == 0;
            }

            public void AddRange(string[] arr)
            {
                foreach (var item in arr)
                {
                    base.Push(item);
                }
            }

            public override string ToString()
            {
                return $"Elements: {string.Join(", ", this)}";
            }
        }

}
}
