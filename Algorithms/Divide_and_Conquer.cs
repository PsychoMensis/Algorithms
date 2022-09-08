using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Divide_and_Conquer
    {
        public int Sum(int[] arr, int length)
        {
            int i = length-1;
            if (i == 0) return arr[0];
            return arr[i] + Sum(arr, i);
        }
    }
}
