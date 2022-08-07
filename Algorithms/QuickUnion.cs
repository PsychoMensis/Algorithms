using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class QuickUnion
    {
        protected int[] id;

        public virtual void QuickFindUF(int N)
        {
            id = new int[N];
            
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
            }
        }
        
        protected int Root(int i)
        {
            while (i != id[i]) i = id[i];
            return i;
        }
        
        public bool Connected(int p, int q)
        {
            return (Root(p) == Root(q));
        }

        public virtual void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            id[i] = j;
        }

    }
}
