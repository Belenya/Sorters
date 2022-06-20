using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class IncreaseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((IComparable)x).CompareTo((IComparable)y);
        }
    }

    public class DecreaseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((IComparable)(y)).CompareTo((IComparable)x);
        }
    }
}
