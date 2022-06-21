using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlghoritms
{
    public class MergeSorter
    {
        static Array tempArray;
        static Type arrayType;

        public void Sort(Array array, IComparer comparer)
        {
            arrayType = array.GetType().GetElementType();
            tempArray = Array.CreateInstance(arrayType, array.Length);
            Sort(array, 0, array.Length - 1, comparer);
        }

        void Sort(Array array, int start, int end, IComparer comparer)
        {
            if (start == end) return;
            var middle = (start + end) / 2;
            Sort(array, start, middle, comparer);
            Sort(array, middle + 1, end, comparer);
            Merge(array, start, middle, end, comparer);
        }

        public void Merge(Array array, int start, int middle, int end, IComparer comparer)
        {
            var leftArrayElPos = start;
            var rightArrayElPos = middle;
            var subArrayLength = end - start + 1;
            Type type = array.GetType().GetElementType();
            var tempArray = Array.CreateInstance(type, subArrayLength);

            for (var i = 0; i < subArrayLength; i++)
            {
                var rightArrayEl = array.GetValue(rightArrayElPos);
                var leftArrayEl = array.GetValue(leftArrayElPos);
                if ((comparer.Compare(rightArrayEl, leftArrayEl) > 0 && leftArrayElPos < middle) || rightArrayElPos > end)
                {
                    tempArray.SetValue(leftArrayEl, i);
                    leftArrayElPos++;
                }
                else
                {
                    tempArray.SetValue(rightArrayEl, i);
                    rightArrayElPos++;
                }
            }
            for (int i = 0; i < subArrayLength; i++)
                array.SetValue(tempArray.GetValue(i), i + start);
        }

        public void MergeForTest(Array array, int start, int middle, int end, IComparer comparer)
        {
            var leftArrayElPos = start;
            var rightArrayElPos = middle;
            var subArrayLength = end - start + 1;
            Type type = array.GetType().GetElementType();
            var tempArray = Array.CreateInstance(type, subArrayLength);

            for (var i = 0; i < subArrayLength; i++)
            {
                var rightArrayEl = array.GetValue(rightArrayElPos);
                var leftArrayEl = array.GetValue(leftArrayElPos);
                if ((comparer.Compare(rightArrayEl, leftArrayEl) > 0 && leftArrayElPos < middle) || rightArrayElPos > end)
                {
                    tempArray.SetValue(leftArrayEl, i);
                    leftArrayElPos++;
                }
                else
                {
                    tempArray.SetValue(rightArrayEl, i);
                    rightArrayElPos++;
                }
            }
            for (int i = 0; i < subArrayLength; i++)
                array.SetValue(tempArray.GetValue(i), i + start);
        }
    }
}
