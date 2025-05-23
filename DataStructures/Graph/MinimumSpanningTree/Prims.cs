﻿using DataStructures.Heap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph.MinimumSpanningTree
{
    public class Prims<T, TW>
            where T : IComparable where TW : IComparable
    {
        public List<MSTEdge<T, TW>> FindMinimumSpanningTree(IGraph<T> graph)
        {
            var edges = new List<MSTEdge<T, TW>>();

            dfs(graph,
                graph.ReferenceVertex,
                new Heap.BinaryHeap<MSTEdge<T, TW>>(Shared.SortDirection.Ascending),
                new HashSet<T>(),
                edges);

            return edges;
        }

        private void dfs(IGraph<T> graph,
            IGraphVertex<T> currentVertex,
            BinaryHeap<MSTEdge<T, TW>> spNeighbor,
            HashSet<T> spVertices,
            List<MSTEdge<T, TW>> spEdges)
        {
            while (true)
            {
                foreach (var edge in currentVertex.Edges)
                {

                    spNeighbor.Add(new MSTEdge<T, TW>(currentVertex.Key,
                                                edge.TargetVertexKey,
                                                edge.Weight<TW>()));
                }

                var minEdge = spNeighbor.DeleteMinMax();

                while (spVertices.Contains(minEdge.Source) && spVertices.Contains(minEdge.Destination))
                {
                    minEdge = spNeighbor.DeleteMinMax();
                    if (spNeighbor.Count == 0)
                        return;
                }

                if (!spVertices.Contains(minEdge.Source))
                {
                    spVertices.Add(minEdge.Source);
                }

                spVertices.Add(minEdge.Destination);
                spEdges.Add(minEdge);
                Console.WriteLine("Eklendi : {0}", minEdge.ToString());

                currentVertex = graph.GetVertex(minEdge.Destination);
            }
        }
    }
}
