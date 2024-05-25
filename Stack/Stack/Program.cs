using System.Collections.Generic;
using System;

namespace Stack
{
    public class Program
    {
        public static void Main()
        {
            Stack<string> stack = new Stack<string>();

            string elementOne = "one";
            string elementTwo = "two";
            string elementThree = "three";

            stack.Push(elementOne);
            stack.Push(elementTwo);
            stack.Push(elementThree);

            Console.WriteLine($"Adding elements to stack: {elementOne}, {elementTwo}, {elementThree}");

            Console.WriteLine($"Lenght: {stack.Count}");

            Console.WriteLine($"Getting element in top without removing: {stack.Peek()}\n");

            for (int i = 0; i < stack.Count;)
                Console.WriteLine($"Getting element in top with removing: {stack.Pop()}");
        }
    }
}
