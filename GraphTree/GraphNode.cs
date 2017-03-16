using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTree
{
    class GraphNode
    {
        public string Name;
        public bool Visited;
        public List<Edge> NeighborEdges;

        public GraphNode(string name)
        {
            Name = name;
            Visited = false;
            NeighborEdges = new List<Edge>();
        }
    }
}
