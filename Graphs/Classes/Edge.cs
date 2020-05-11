using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    //creates an  edge for each node in the graph
    class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }
    }
}
