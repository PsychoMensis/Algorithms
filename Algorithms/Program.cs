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
            int [] BS = new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 1,  12, 13 };

            SelectionSort sort = new SelectionSort();
            int[] sorted = sort.SelSort(BS);

        }
    }
}