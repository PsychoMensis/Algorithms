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

            QuickFind quickFind = new QuickFind();

            quickFind.QuickFindUF(10);
            quickFind.Union(4, 3);
            quickFind.Union(3, 8);
            quickFind.Union(6, 5);
            quickFind.Union(9, 4);
            quickFind.Union(2, 1);
            quickFind.Connected(8, 9);
            quickFind.Connected(5, 0);
            quickFind.Union(5, 0);
            quickFind.Union(7, 2);
            quickFind.Union(6, 1);

        }
    }
}