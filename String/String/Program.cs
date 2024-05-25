using System;

namespace String
{
    public class Program
    {
        public static void Main()
        {
            string text = "Hello World";
            string symbol = "!";

            string result = text + symbol;

            Console.WriteLine(result);
            Console.WriteLine($"Lenght: {result.Length}");

            int index = 6;
            Console.WriteLine($"Taking symbol from index ({index}): {result[index]}");

            index = 4;
            Console.WriteLine($"Removing symbol from index ({index}): {result.Remove(index, 1)}");

            char anySymbol = 'e';
            Console.WriteLine($"Getting index of any symbol ({anySymbol}): {result.IndexOf(anySymbol)}");

            string addingSymbol = " -";
            int spaceIndex = 5;
            Console.WriteLine($"Adding symbol ({addingSymbol}) to index ({spaceIndex}): {result.Insert(spaceIndex, addingSymbol)}");
        }
    }
}
