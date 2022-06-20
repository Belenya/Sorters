using System;

namespace BubbleSort
{
    public class Program
    {
        public static void Main()
        {
            var array = new object[] {4, 3, 2, 1, 4, 3, 2, 1 };
            var bubbleSort = new BubbleSorter();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(1.CompareTo(2));
            bubbleSort.Sort(array, new IncreaseComparer());

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}