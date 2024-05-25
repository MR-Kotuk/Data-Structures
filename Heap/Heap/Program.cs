using System.Collections.Generic;
using System;

namespace Heap
{
    public class Program
    {
        public static void Main()
        {
            MinHeap heap = new MinHeap();

            Console.WriteLine("Adding elements to min heap:");
            for (int i = 0; i < 5; i++)
            {
                int randomNum = new Random().Next(100);
                heap.Add(randomNum);
                Console.Write($"{randomNum} ");
            }

            Console.WriteLine($"\n\nLength: {heap.GetCount()}");

            Console.WriteLine($"\nGetting minimal element without removing: {heap.Peek()}\n");

            Console.WriteLine("Getting min elements with removing:");
            for (int j = 0; j < heap.GetCount();)
                Console.Write($"{heap.Pop()} ");
        }
    }

    public class MinHeap
    {
        private List<int> elements = new List<int>();

        public int GetCount()
        {
            return elements.Count;
        }

        public int Peek()
        {
            if (elements.Count == 0)
                Console.WriteLine("Error, size of min heap is 0");

            return elements[0];
        }

        public int Pop()
        {
            if (elements.Count == 0)
                Console.WriteLine("Error, size of min heap is 0");

            int result = elements[0];

            elements[0] = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);

            MoveDown(0);

            return result;
        }

        public void Add(int element)
        {
            elements.Add(element);
            MoveUp(elements.Count - 1);
        }

        private void MoveUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;

                if (elements[parentIndex] <= elements[index])
                    break;

                Move(index, parentIndex);
                index = parentIndex;
            }
        }

        private void MoveDown(int index)
        {
            while (index < elements.Count / 2)
            {
                int childrenIndex = index * 2 + 1;

                if (childrenIndex < elements.Count - 1 && elements[childrenIndex + 1] < elements[childrenIndex])
                    childrenIndex++;

                if (elements[index] <= elements[childrenIndex])
                    break;

                Move(index, childrenIndex);
                index = childrenIndex;
            }
        }

        private void Move(int indexOne, int indexTwo)
        {
            int cache = elements[indexOne];
            elements[indexOne] = elements[indexTwo];
            elements[indexTwo] = cache;
        }
    }
}

