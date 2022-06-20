using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSorter : ISorter
    {
        public void Sort(Array array, IComparer comparer)
        {
            for (var i = 0; i < array.Length; i++)
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (comparer.Compare(array.GetValue(j), array.GetValue(j + 1)) > 0)
                    {
                        var temp = array.GetValue(j + 1);
                        array.SetValue(array.GetValue(j), j + 1);
                        array.SetValue(temp, j);
                    }
                }
        }
    }
}
