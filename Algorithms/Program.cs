using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Algorithms
{
    internal class Program
    {
        public static int Binary_Search(int [] Array, int element)
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
        public static void Main(string[] args)
        {
            int [] BS = new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        }
    }
}