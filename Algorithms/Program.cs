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
            int [] BS = new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            WeightedQuickUnion quickUnion = new WeightedQuickUnion();

            quickUnion.QuickFindUF(10);
            quickUnion.Union(4, 3);
            quickUnion.Union(3, 8);
            quickUnion.Union(6, 5);
            quickUnion.Union(9, 4);
            quickUnion.Union(2, 1);
            quickUnion.Union(9, 4);
            quickUnion.Union(5, 0);
            quickUnion.Union(7, 2);
            quickUnion.Union(6, 1);
            quickUnion.Union(7, 3);

            Console.WriteLine(quickUnion.Connected(8, 9));
            Console.WriteLine(quickUnion);

        }
    }
}