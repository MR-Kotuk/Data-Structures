using System;

namespace Arrays
{
    public class Program
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3 };

            DisplayArray(array);

            Console.WriteLine($"Lenght: {array.Length}");

            int index = 1;
            Console.WriteLine($"Getting element from index({index}): {array[index]}");

            int newValue = 128;
            array[index] = newValue;
            Console.WriteLine($"Switch element from index ({index}) to: {array[index]}");

            DisplayArray(array);


            Console.WriteLine("\nMultiplay array:\n");

            int[,] multiplayArray = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            DisplayArray(multiplayArray);

            Console.WriteLine($"Lenght: {multiplayArray.Length}\nLenght 0: {multiplayArray.GetLength(0)}\nLenght 1: {multiplayArray.GetLength(1)}");

            int indexX = 1;
            int indexY = 1;
            Console.WriteLine($"Getting element from index({indexX}, {indexY}): {multiplayArray[indexX, indexY]}");

            int newValueOfMultiplayArray = 10;
            multiplayArray[indexX, indexY] = newValueOfMultiplayArray;
            Console.WriteLine($"Switch element from index ({indexX}, {indexY}) to: {multiplayArray[indexX, indexY]}");

            DisplayArray(multiplayArray);
        }

        private static void DisplayArray(int[] array)
        {
            Console.WriteLine("Showig elements from array:");

            foreach (int num in array)
                Console.Write($"{num} ");

            Console.WriteLine();
        }

        private static void DisplayArray(int[,] array)
        {
            Console.WriteLine("Showig elements from array:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");

                Console.WriteLine();
            }
        }
    }
}
