﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public interface ISorter
    {
        void Sort(Array array, IComparer comparer);
    }
}