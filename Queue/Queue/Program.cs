using System.Collections.Generic;
using System;

namespace Queue
{
    public class Program
    {
        public static void Main()
        {
            Queue<string> queue = new Queue<string>();

            string elementOne = "one";
            string elementTwo = "two";
            string elementThree = "three";

            queue.Enqueue(elementOne);
            queue.Enqueue(elementTwo);
            queue.Enqueue(elementThree);

            Console.WriteLine($"Adding elements to queue: {elementOne}, {elementTwo}, {elementThree}");

            Console.WriteLine($"Lenght: {queue.Count}");

            Console.WriteLine($"Getting element in top without removing: {queue.Peek()}\n");

            for (int i = 0; i < queue.Count;)
                Console.WriteLine($"Getting element in top with removing: {queue.Dequeue()}");
        }
    }
}
