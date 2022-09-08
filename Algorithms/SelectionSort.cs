using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class SelectionSort
    {
        public int FindSmallest(int[] arr)
        {
            int smallest = arr[0];
            int smallestIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;

           
        }
        public int[] SelSort(int[] arr)
        {
            int [] SortedArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int smallest = FindSmallest(arr);
                SortedArr[i] = arr[smallest];
                arr[smallest] = int.MaxValue;
            }
            return SortedArr;
        }
    }
}
