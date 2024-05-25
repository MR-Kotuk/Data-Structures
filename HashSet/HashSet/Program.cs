using System.Collections.Generic;
using System;

namespace HashSet
{
    public class Program
    {
        public static void Main()
        {
            HashSet<int> uniqueNums = new HashSet<int>();

            int randomNumsCount = 20;
            Console.WriteLine($"Adding random numbers in range ({randomNumsCount}):");
            for (int i = 0; i < randomNumsCount; i++)
            {
                int randomNum = new Random().Next(randomNumsCount);
                Console.Write($"{randomNum} ");
                uniqueNums.Add(randomNum);
            }

            Console.WriteLine($"\n\nLength: {uniqueNums.Count}");

            ShowHashSet(uniqueNums);

            int tryNum = 17;
            Console.Write($"\n\nContain hash set {tryNum}: {uniqueNums.Contains(tryNum)}");

            while (!uniqueNums.Contains(tryNum))
                tryNum = new Random().Next(0, uniqueNums.Count);

            Console.WriteLine($"\nRemoving {tryNum}");
            uniqueNums.Remove(tryNum);
            ShowHashSet(uniqueNums);

            Console.Write("\n\nClear:");
            uniqueNums.Clear();
            ShowHashSet(uniqueNums);
        }

        private static void ShowHashSet(HashSet<int> hashSet)
        {
            if (hashSet.Count != 0)
            {
                Console.WriteLine("\nShow elements in hash set:");

                foreach (int num in hashSet)
                    Console.Write($"{num} ");
            }
            else
                Console.WriteLine("\nError, length of hash set is 0");
        }
    }
}
