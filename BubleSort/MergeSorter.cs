using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritms
{
    public class MergeSorter : ISorter
    {
        static Array tempArray;
        static Type arrayType;

        public void Sort(Array array, IComparer comparer)
        {
            arrayType = array.GetType().GetElementType();
            tempArray = Array.CreateInstance(arrayType, array.Length);
            Sort(array, 0, array.Length - 1, comparer);
        }

        public void Sort(Array array, int start, int end, IComparer comparer)
        {
            if (start == end) return;
            int middle = (start + end) / 2;
            Sort(array, start, middle, comparer);
            Sort(array, middle + 1, end, comparer);
            Merge(array, start, middle, end, comparer);
        }

        public void Merge(Array array, int start, int middle, int end, IComparer comparer)
        {
            var leftArrayElPos = start;
            var rightArrayElPos = middle + 1;
            var subArrayLength = end - start + 1;

            for (var i = 0; i < subArrayLength; i++)
            {
                if (rightArrayElPos > end || (comparer.Compare(array.GetValue(rightArrayElPos), array.GetValue(leftArrayElPos)) > 0 && leftArrayElPos <= middle))
                {
                    tempArray.SetValue(array.GetValue(leftArrayElPos), i);
                    leftArrayElPos++;
                }
                else
                {
                    tempArray.SetValue(array.GetValue(rightArrayElPos), i);
                    rightArrayElPos++;
                }
            }
            for (int i = 0; i < subArrayLength; i++)
                array.SetValue(tempArray.GetValue(i), i + start);
        }
    }
}
