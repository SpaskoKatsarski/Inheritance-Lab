using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return base.Count == 0;
        }

        public Stack<string> AddRange(string[] elements)
        {
            foreach (var element in elements)
            {
                base.Push(element);
            }

            return this;
        }
    }
}
