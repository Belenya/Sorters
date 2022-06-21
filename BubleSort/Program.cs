using System;

namespace SortingAlghoritms
{
    public class Program
    {
        public static void Main()
        {
            var array = new object[] {4, 3, 2, 1};
            var bubbleSort = new BubbleSorter();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            bubbleSort.Sort(array, new IncreaseComparer());
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            bubbleSort.Sort(array, new DecreaseComparer());
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}