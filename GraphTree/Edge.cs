using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTree
{
    class Edge
    {
        public int IndexFrom;
        public int IndexTo;
        public int Cost;

        public Edge(int indexFrom, int indexTo, int cost)
        {
            IndexFrom = indexFrom;
            IndexTo = indexTo;
            Cost = cost;
        }
    }
}
