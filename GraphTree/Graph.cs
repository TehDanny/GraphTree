using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTree
{
    class Graph
    {
        List<GraphNode> Nodes;

        public Graph()
        {
            Nodes = new List<GraphNode>();
        }

        public void AddNode(GraphNode node)
        {
            Nodes.Add(node);
        }

        public void AddDirectedNeighborEdge(Edge edge)
        {
            Nodes[edge.IndexFrom].NeighborEdges.Add(edge);
        }

        public void AddUndirectedNeighborEdge(Edge edge)
        {
            Nodes[edge.IndexFrom].NeighborEdges.Add(edge);

            Edge edge2 = new Edge(edge.IndexTo, edge.IndexFrom, edge.Cost);
            Nodes[edge2.IndexFrom].NeighborEdges.Add(edge2);
        }

        /*
        public string PrintGraphMatrix()
        {
            string indexes = "Indexes: ";
            for (int i = 0; i < Nodes.Count -1; i++)
            {
                indexes = +i + ": " + Nodes[i].Name + ". ";
            }

            string matrix = "  |";
            for (int i = 0; i < Nodes.Count - 1; i++)
            {
                matrix += " " + i + " |";
            }
            matrix += "\n";
            for (int i = 0; i < Nodes.Count - 1; i++)
            {
                matrix += i + "|";
                for (int j = 0; j < Nodes.Count - 1; j++)
                {
                    matrix =+ Nodes[i].NeighborEdges
                }
            }
            return indexes + matrix;
        }
        */

        public string PrintGraph()
        {
            string graphString = string.Empty;

            for (int i = 0; i < Nodes.Count - 1; i++)
            {
                graphString += Nodes[i].Name + ": ";
                foreach (var item in Nodes[i].NeighborEdges)
                {
                    graphString += Nodes[item.IndexTo].Name + ": " + item.Cost + "| ";
                }

                graphString += "\n";
            }

            return graphString;
        }
    }
}
