using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritms
{
    public class QuickSorter : ISorter
    {
        public void Sort(Array array, IComparer comparer)
        {
            Sort(array, 0, array.Length - 1, comparer);
        }
        public void Sort(Array array, int start, int end, IComparer comparer)
        {
            if (start == end) return;
            var pivot = array.GetValue(end);
            var storeIndex = start;          
            for (var i = start; i <= end - 1; i++)
            {
                if (comparer.Compare(pivot, array.GetValue(i)) >= 0)
                {
                    var temp = array.GetValue(i);
                    array.SetValue(array.GetValue(storeIndex), i);
                    array.SetValue(temp, storeIndex);
                    storeIndex++;
                }
            }
            var temp1 = array.GetValue(storeIndex);
            array.SetValue(array.GetValue(end), storeIndex);
            array.SetValue(temp1, end);
            if (storeIndex > start) Sort(array, start, storeIndex - 1, comparer);
            if (storeIndex < end) Sort(array, storeIndex + 1, end, comparer);
        }
    }
}
