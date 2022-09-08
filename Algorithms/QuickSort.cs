using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class QuickSort
    {
        private int Pivot(int [] arr, int min, int max)
        {
            int pivot = min -1;
            for (int i = min; i < max; i++)
            {
                if (arr[i] < arr[max])
                {
                    pivot++;
                    Swap(ref arr[pivot], ref arr[i]);
                    
                }
            }
            pivot++;
            Swap(ref arr[pivot], ref arr[max]);
            
            return pivot;
        }
        private void Swap(ref int first, ref int second)
        {
            int temp = first;

            first = second;

            second = temp;
        }

        public int[] AscendingSort(int[] arr, int min, int max)
        {
            if (min >= max) return arr;

            int pivot = Pivot(arr, min, max);

            AscendingSort(arr, min, pivot - 1);

            AscendingSort(arr, pivot + 1, max);

            return arr;
        }
        public int[] DescendingSort(int[] arr, int min, int max)
        {
            if (min >= max) return arr;

            int pivot = DescendingPivot(arr, min, max);

            DescendingSort(arr, min, pivot - 1);

            DescendingSort(arr, pivot + 1, max);

            return arr;
        }
        private int DescendingPivot(int[] Array, int MinIndex, int MaxIndex)
        {
            int Pivot = MaxIndex + 1;

            for (int i = MaxIndex; i > MinIndex - 1; i--)
            {
                if (Array[MinIndex] > Array[i])
                {
                    Pivot--;
                    Swap(ref Array[Pivot], ref Array[i]);
                }
            }
            Pivot--;
            Swap(ref Array[MinIndex], ref Array[Pivot]);

            return Pivot;
        }
    }
}
