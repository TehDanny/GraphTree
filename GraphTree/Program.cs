using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            GraphNode node1 = new GraphNode("Odense");
            graph.AddNode(node1);
            GraphNode node2 = new GraphNode("Middelfart");
            graph.AddNode(node2);
            GraphNode node3 = new GraphNode("Bogense");
            graph.AddNode(node3);
            GraphNode node4 = new GraphNode("Otterup");
            graph.AddNode(node4);
            GraphNode node5 = new GraphNode("Ringe");
            graph.AddNode(node5);
            GraphNode node6 = new GraphNode("Assens");
            graph.AddNode(node6);
            GraphNode node7 = new GraphNode("Kerteminde");
            graph.AddNode(node7);
            GraphNode node8 = new GraphNode("Svendborg");
            graph.AddNode(node8);
            GraphNode node9 = new GraphNode("Nyborg");
            graph.AddNode(node9);

            Edge edge1 = new Edge(0, 1, 67);
            graph.AddUndirectedNeighborEdge(edge1);
            Edge edge2 = new Edge(2, 3, 67);
            graph.AddUndirectedNeighborEdge(edge2);
            Edge edge3 = new Edge(3, 0, 22);
            graph.AddUndirectedNeighborEdge(edge3);
            Edge edge4 = new Edge(4, 5, 43);
            graph.AddUndirectedNeighborEdge(edge4);
            Edge edge5 = new Edge(5, 0, 59);
            graph.AddUndirectedNeighborEdge(edge5);
            Edge edge6 = new Edge(0, 6, 33);
            graph.AddUndirectedNeighborEdge(edge6);
            Edge edge7 = new Edge(7, 0, 150);
            graph.AddUndirectedNeighborEdge(edge7);
            Edge edge8 = new Edge(0, 2, 49);
            graph.AddUndirectedNeighborEdge(edge8);
            Edge edge9 = new Edge(2, 1, 38);
            graph.AddUndirectedNeighborEdge(edge9);
            Edge edge10 = new Edge(1, 5, 61);
            graph.AddUndirectedNeighborEdge(edge10);
            Edge edge11 = new Edge(7, 8, 45);
            graph.AddUndirectedNeighborEdge(edge11);
            Edge edge12 = new Edge(8, 0, 58);
            graph.AddUndirectedNeighborEdge(edge12);
            Edge edge13 = new Edge(7, 4, 56);
            graph.AddUndirectedNeighborEdge(edge13);

            Console.WriteLine("Printed graph:");
            Console.WriteLine(graph.PrintGraph());

            Console.WriteLine("Depth first traversal: ");
            Console.WriteLine(graph.TraversalDepthFirstRecursive());
            Console.ReadLine();
        }
    }
}
