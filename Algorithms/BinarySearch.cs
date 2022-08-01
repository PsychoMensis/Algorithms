using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class BinarySearch
    {
        public static int Binary_Search(int[] Array, int element)
        {
            int low, high, mid, guess;
            low = 0;
            high = Array.Length - 1;

            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = Array[mid];
                if (guess == element)
                {
                    return mid;
                }
                else if (guess > element)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
