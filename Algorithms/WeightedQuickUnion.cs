using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class WeightedQuickUnion : QuickUnion
    {
        int[] sz;

        public override void QuickFindUF(int N)
        {
            id = new int[N];
            sz = new int[N];

            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                sz[i] = 1;
            }
        }
        public override void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            if (i == j) return;

            if (sz[i] > sz[j])
            {
                id[i] = j;
                sz[j] += sz[i];
            }
            else
            {
                id[j] = i;
                sz[i] += sz[i]; 
            }
        }
    }
}
