using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySearch<T> where T : IComparable
    {
        T[] arr;
        public BinarySearch(T[] arr)
        {
            this.arr = arr;
            Array.Sort(this.arr);
        }
        public int FindWord(T word, int min, int max)
        {
            int mid = min;
            while (min < max)
            {
                mid = (min + max) / 2;
                if (arr[mid].CompareTo(word)==0)
                {
                    return 1;
                }
                else if (arr[mid].CompareTo(word) > 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            if (arr[mid].CompareTo(word)!=0)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }
    }  
}
