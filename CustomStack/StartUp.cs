using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            stackOfStrings.AddRange(new string[] { "Ivan", "Stoyan" });
            Console.WriteLine(stackOfStrings.AddRange(new string[] { "Ivan", "Stoyan" }));
            Console.WriteLine(stackOfStrings.IsEmpty());
            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.IsEmpty());
        }
    }
}
