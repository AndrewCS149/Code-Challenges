using System;
using System.Collections.Generic;
using Graphs;

namespace Graphs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    public class Graph
    {
        public Node[] Nodes { get; set; }
    }

    public class Node
    {
        public char Val { get; set; }

        //public IList<Node> Neighbors { get; private set; }
        public ICollection<Node> Neighbors { get; set; }

        public Node(char val)
        {
            Neighbors = new LinkedList<Node>();
            Val = val;
        }
    }
}