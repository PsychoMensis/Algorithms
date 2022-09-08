using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Algorithms
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            int [] BS = new int[] { 4, 6, 8, 2, 1, 3, 10, 51, 5,  34, 17 };
            int[] BS2 = new int[] { 24, 44, 36, 25 };

            QuickSort qs = new QuickSort();

            int[] a = qs.AscendingSort(BS, 0, BS.Length - 1);

            int [] b = qs.DescendingSort(BS2, 0, BS2.Length - 1);

        }




    }
}