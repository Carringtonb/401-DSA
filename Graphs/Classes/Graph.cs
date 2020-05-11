using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        private int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        // Add Node/Vertex to the graph/adjacency List
        public Vertex<T> AddNode(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            _size++;
            return node;
        }

        // add edge
        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(
                new Edge<T>
                {
                    Vertex = b,
                    Weight = weight

                }
                );
        }
        // uses AddDirectedEdge method to add two edges, so they are undirected
        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }
        /// <summary>
        /// Checks the list of vertices and returns them
        /// </summary>
        /// <returns>Vertices</returns>
        public List<Vertex<T>> GettAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }

            return vertices;
        }

        // Get Neighbors
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            // get all edges connected to a vertex
            return AdjacencyList[vertex];
        }
        // returns the size of the graph, which is incremented every time a node is added.
        public int Size()
        {
            return _size;
        }
        // write all the nodes in the graph to the console.
        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                Console.Write($"{vertex.Key.Value}: ");

                foreach (var edge in vertex.Value)
                {
                    Console.Write($"{edge.Vertex.Value}, {edge.Weight} ->");
                }
                Console.WriteLine("null");
            }
        }

    }
}