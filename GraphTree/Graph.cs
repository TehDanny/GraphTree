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
        List<GraphNode> VisitedNodes;

        public Graph()
        {
            Nodes = new List<GraphNode>();
            VisitedNodes = new List<GraphNode>();
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

        public void ClearVisits()
        {
            for (int i = 0; i < Nodes.Count - 1; i++)
            {
                Nodes[i].Visited = false;
            }
        }

        public string TraversalDepthFirstRecursive()
        {
            string traversal = string.Empty;

            Nodes[0].Visited = true;
            VisitedNodes.Add(Nodes[0]);
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            TraversalDepthFirstRecursive(stack);

            foreach (var item in VisitedNodes)
            {
                traversal += item.Name + ", ";
            }

            return traversal;
        }

        public Stack<int> TraversalDepthFirstRecursive(Stack<int> stack)
        {
            foreach (var item in Nodes[stack.Last()].NeighborEdges)
            {
                if (Nodes[item.IndexTo].Name == "Ringe")
                {
                    int test = 0;
                }
                if (Nodes[item.IndexTo].Visited == false)
                {
                    stack.Push(item.IndexTo);
                    Nodes[item.IndexTo].Visited = true;
                    VisitedNodes.Add(Nodes[item.IndexTo]);
                    return TraversalDepthFirstRecursive(stack);
                }
            }
            stack.Pop();
            return stack;
        }
    }
}
