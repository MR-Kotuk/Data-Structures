using System.Collections.Generic;
using System;

namespace List
{
    public class Program
    {
        public static void Main()
        {
            List<int> list = new List<int>();

            int newElementOne = 1;
            int newElementTwo = 2;
            int newElementThree = 3;

            list.Add(newElementOne);
            list.Add(newElementTwo);
            list.Add(newElementThree);

            Console.Write("Adding three elements to list: ");
            ShowList(list);

            Console.WriteLine($"Lenght: {list.Count}");

            int index = 1;
            Console.WriteLine($"Getting element from index({index}): {list[index]}");

            Console.WriteLine($"Removing element from index ({index}): {list[index]}");
            list.Remove(list[index]);
            ShowList(list);

            int newElement = 56;
            list[index] = newElement;
            Console.WriteLine($"Switched element from index ({index}): {list[index]}");
            ShowList(list);

            Console.WriteLine("Removing all elements from list...");
            list.Clear();
            ShowList(list);

            Console.Write("Adding random elements to list:");

            int count = 10;
            for (int i = 0; i < count; i++)
                list.Add(new Random().Next(100));

            ShowList(list);

            Console.WriteLine("Sorting elements from list:");
            list.Sort();
            ShowList(list);
        }

        private static void ShowList(List<int> list)
        {
            Console.WriteLine("\nShowing list:");

            foreach (int element in list)
                Console.Write($"{element} ");

            Console.WriteLine();
        }
    }
}
