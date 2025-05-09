using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph.Search
{
    public class BreadthFirst<T>
    {
        public bool Find(IGraph<T> graph, T vertexKey)
        {
            return bfs(graph.ReferenceVertex, new HashSet<T>(),vertexKey);
        }

        private bool bfs(IGraphVertex<T> referenceVertex, HashSet<T> visited, T searchVertexKey)
        {
            var q = new Queue<IGraphVertex<T>>();
            q.Enqueue(referenceVertex);
            visited.Add(referenceVertex.Key);
            while (q.Count > 0)
            {
                var current = q.Dequeue();
                if (current.Key.Equals(searchVertexKey))
                    return true;

                foreach (var edge in current.Edges)
                {
                    if(visited.Contains(edge.TargetVertexKey))
                        continue;
                    visited.Add(edge.TargetVertexKey);
                    q.Enqueue(edge.TargetVertex);
                }
            }
            return false;

        }

    }
}
