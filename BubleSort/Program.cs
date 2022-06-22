using System;

namespace SortingAlgoritms
{
    public class Program
    {
        public static void Main()
        {
            var array = new int[] {1, 2, 3 ,4 };
            var sorter = new MergeSorter();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            sorter.Sort(array, new DecreaseComparer());
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}