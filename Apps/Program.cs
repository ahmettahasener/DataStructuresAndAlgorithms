using System;
using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.Stack;
using DataStructures.Tree.BinaryTree;
using DataStructures.Heap;
using DataStructures.Shared;
using DataStructures.Graph;
using DataStructures.Graph.AdjancencySet;
using DataStructures.Graph.Search;
using DataStructures.SortingAlgorithms;


namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //var arr = new DataStructures.Array.Array<int>();
            //var arr2 = new DataStructures.Array.Array<int>(3,15,36,42);

            //var p1 = new DataStructures.Array.Array<int>(1,2,3,4);
            //var p2 = new int[] {5,6,7};
            //var p3 = new List<int>() {8,9,10};
            //var p4 = new ArrayList() { 11, 12, 13 };//it will not accept this because it is not type safe

            //var arr3 = new DataStructures.Array.Array<int>(p1);
            //var arr4 = new DataStructures.Array.Array<int>(p2);
            //var arr5 = new DataStructures.Array.Array<int>(p3);

            //var crr = arr.Clone() as DataStructures.Array.Array<int>;


            //arr.Add(12);
            //arr.Add(25);
            //arr.Add(36);
            //arr.Add(61);
            //arr.Remove();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---");

            //arr.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));

            //Console.WriteLine($"{ arr.Count} / {arr.Capacity}");

            //DataStructures.Array.Array<string> str = new DataStructures.Array.Array<string>() { "this", "is","test" };
            //var strCopy = str.Clone() as DataStructures.Array.Array<string>;
            //str.Add("new word");


            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---");
            //foreach (var item in strCopy)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region SinglyLinkedList

            //var singlyLinkedList = new SinglyLinkedList<int>();

            //singlyLinkedList.AddFirst(1);
            //singlyLinkedList.AddFirst(2);

            //singlyLinkedList.AddLast(5);
            //singlyLinkedList.AddLast(6);

            //singlyLinkedList.AddBefore(singlyLinkedList.Head.Next, 23);
            //singlyLinkedList.AddBefore(singlyLinkedList.Head.Next.Next, 28);

            //singlyLinkedList.AddAfter(singlyLinkedList.Head, 45);
            //singlyLinkedList.AddAfter(singlyLinkedList.Head.Next, 17);

            //foreach (int item in singlyLinkedList)
            //{
            //    Console.WriteLine(item);
            //}

            //singlyLinkedList.Clear();

            //Console.WriteLine(singlyLinkedList.Head);

            //var arr = new char[] { 'a', 'b', 'c' };
            //var arrList = new ArrayList(arr);
            //var list = new List<char>(arr);
            //var cLinkedList = new LinkedList<char>(arr);

            //var linkedList = new SinglyLinkedList<char>(arr);
            //var linkedList1 = new SinglyLinkedList<char>(list);


            ////Language Integrated Query - LINQ
            //var rnd = new Random();
            //var initial = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();
            //var linkedlist3 = new SinglyLinkedList<int>(initial);

            //var q = from item in linkedlist3 where item % 2 == 1 select item;

            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //}

            //linkedlist3.Where(x => x > 5).ToList().ForEach(x => Console.Write(x + " "));
            #endregion

            #region DoublyLinkedList

            //var doublyLinkedList = new DoublyLinkedList<int>();
            //var list = new DoublyLinkedList<char>(new List<char>() { 'a','b','c'});
            //var list2 = new DoublyLinkedList<char>(new char[] { 'a','b','c'});

            //doublyLinkedList.AddFirst(13);
            //doublyLinkedList.AddFirst(34);

            //doublyLinkedList.AddLast(25);

            //doublyLinkedList.AddAfter(doublyLinkedList.Tail, new DoublyLinkedListNode<int>(68));
            //doublyLinkedList.AddBefore(doublyLinkedList.Head, new DoublyLinkedListNode<int>(72));

            //doublyLinkedList.RemoveFirst();
            //doublyLinkedList.RemoveLast();
            //doublyLinkedList.Remove(68);
            //foreach (var item in doublyLinkedList) {
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Stack

            //var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
            //var stack1 = new DataStructures.Stack.Stack<char>();
            //var stack2 = new DataStructures.Stack.Stack<char>(StackType.LinkedList);

            //foreach (var c in charset)
            //{
            //    stack1.Push(c);
            //    stack2.Push(c);
            //}

            //Console.WriteLine(stack1.Peek());
            //Console.WriteLine(stack2.Peek());

            //Console.WriteLine(stack1.Pop());
            //Console.WriteLine(stack2.Pop());

            //Console.WriteLine(stack1.Count);
            //Console.WriteLine(stack2.Count);

            //stack1.Clear();
            //stack2.Clear();
            #endregion

            #region Queue

            //var numbers = new int[] { 1, 2, 3 };
            //var q1 = new DataStructures.Queue.Queue<int>();
            //var q2 = new DataStructures.Queue.Queue<int>(DataStructures.Queue.QueueType.LinkedList);

            //foreach (var number in numbers) {
            //    q1.EnQueue(number);
            //    q2.EnQueue(number);
            //}

            //Console.WriteLine($"Queue 1 Count: { q1.Count}");
            //Console.WriteLine($"Queue 2 Count: { q2.Count}");

            //Console.WriteLine(q1.DeQueue());
            //Console.WriteLine(q2.DeQueue());

            //Console.WriteLine($"Queue 1 Count: {q1.Count}");
            //Console.WriteLine($"Queue 2 Count: {q2.Count}");

            //Console.WriteLine(q1.Peek());
            //Console.WriteLine(q2.Peek());

            //Console.WriteLine($"Queue 1 Count: {q1.Count}");
            //Console.WriteLine($"Queue 2 Count: {q2.Count}");
            #endregion

            #region Tree

            //var BST = new DataStructures.Tree.BST.BST<int>(new int[]
            //{
            //    23,16,45,3,22,37,99
            //});

            //var listInOrder = new BinaryTree<int>().InOrder(BST.Root);

            //foreach (var node in listInOrder)
            //{
            //    Console.Write(node + " ");
            //}
            //Console.WriteLine();
            //var listPreOrder = new BinaryTree<int>().PreOrder(BST.Root);

            //foreach (var node in listPreOrder)
            //{
            //    Console.Write(node + " ");
            //}
            //Console.WriteLine();

            //var listPostOrder = new BinaryTree<int>().PostOrder(BST.Root);

            //foreach (var node in listPostOrder)
            //{
            //    Console.Write(node + " ");
            //}
            //Console.WriteLine();

            //var listInOrderNonRecursiveTraversal = new BinaryTree<int>().InOrderNonRecursiveTraversal(BST.Root);

            //foreach (var node in listInOrderNonRecursiveTraversal)
            //{
            //    Console.Write(node + " ");
            //}
            //Console.WriteLine();

            //var listPreOrderNonRecursiveTraversal = new BinaryTree<int>().PreOrderNonRecursiveTraversal(BST.Root);

            //foreach (var node in listPreOrderNonRecursiveTraversal)
            //{
            //    Console.Write(node + " ");
            //}
            //Console.WriteLine();

            //var listLevelOrderNonRecursiveTraversal = new BinaryTree<int>().LevelOrderNonRecursiveTraversal(BST.Root);

            //foreach (var node in listLevelOrderNonRecursiveTraversal)
            //{
            //    Console.Write(node + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine($"Min Value: {BST.FindMin(BST.Root)}");
            //Console.WriteLine($"Max Value: {BST.FindMax(BST.Root)}");
            //Console.WriteLine($"Find Value: {BST.Find(BST.Root,16)}");
            //Console.WriteLine($"Depth: {DataStructures.Tree.BinaryTree.BinaryTree<int>.MaxDepth(BST.Root)}");
            //Console.WriteLine($"Deepest Node: {DataStructures.Tree.BinaryTree.BinaryTree<int>.DeepestNode(BST.Root)}");
            //Console.WriteLine($"Number of Leaves: {DataStructures.Tree.BinaryTree.BinaryTree<int>.NumberOfLeaves(BST.Root)}");
            //new BinaryTree<int>().PrintPaths(BST.Root);
            #endregion

            #region Heap

            //var minHeap = new MinHeap<int>(new int[]
            //{
            //    1,4,8,7,5,10,9,11,9,6
            //});

            //var maxHeap = new MaxHeap<int>(new int[]
            //{
            //    1,4,8,7,5,10,9,11,9,6
            //});

            //foreach (var item in minHeap)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //foreach (var item in maxHeap)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //var heap1 = new BinaryHeap<int>(SortDirection.Descending,
            //    new int[]
            //{
            //    1,4,8,7,5,10,9,11,9,6
            //});

            //foreach (var item in heap1)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //var heap2 = new BinaryHeap<int>(SortDirection.Ascending,
            //    new int[]
            //{
            //    1,4,8,7,5,10,9,11,9,6
            //});

            //foreach (var item in heap2)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Set

            //var disjointSet = new DataStructures.Set.DisjointSet<int>(new int[] {0,1,2,3,4,5,6});

            //disjointSet.Union(5,6);
            //disjointSet.Union(1,2);
            //disjointSet.Union(0,2);

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine($"Find({i}) = {disjointSet.FindSet(i)}");
            //}

            #endregion

            #region Graph

            //var graph = new Graph<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G'});

            //graph.AddEdge('A', 'B');
            //graph.AddEdge('A', 'D');
            //graph.AddEdge('C', 'D');
            //graph.AddEdge('C', 'E');
            //graph.AddEdge('D', 'E');
            //graph.AddEdge('E', 'F');
            //graph.AddEdge('F', 'G');

            //Console.WriteLine("Edge between A and B ? "+ graph.HasEdge('A','B'));
            //Console.WriteLine("Edge between B and A ? "+ graph.HasEdge('B','A'));
            //Console.WriteLine("Edge between B and D ? "+ graph.HasEdge('B','D'));
            //Console.WriteLine("Edge between D and B ? "+ graph.HasEdge('D','B'));

            //foreach (char vertex in graph)
            //{
            //    Console.WriteLine(vertex);
            //}
            //Console.WriteLine();
            //foreach (var key in graph)
            //{
            //    Console.WriteLine(key);
            //    foreach(var vertex in graph.GetVertex(key).Edges)
            //    {
            //        Console.WriteLine("   "+vertex);
            //    }
            //}

            //Console.WriteLine($"Number of vertex in the graph: {graph.Count}");
            //-----------------
            //var graph = new WeightedGraph<char, double>(new char[] {'A','B','C','D'});

            //Console.WriteLine("Edge between A and B ? " + graph.HasEdge('A', 'B'));
            //Console.WriteLine("Edge between B and A ? " + graph.HasEdge('B', 'A'));

            //graph.AddEdge('A', 'B',1.2);
            //graph.AddEdge('A', 'D',2.3);
            //graph.AddEdge('D', 'C',5.5);

            //Console.WriteLine("Edge between A and B ? " + graph.HasEdge('A', 'B'));
            //Console.WriteLine("Edge between B and A ? " + graph.HasEdge('B', 'A'));

            //foreach (var vertex in graph)
            //{
            //    Console.WriteLine(vertex);
            //}

            //Console.WriteLine();

            //foreach (char vertex in graph)
            //{
            //    Console.WriteLine(vertex);
            //    foreach (char key in graph.GetVertex(vertex))
            //    {
            //        var node = graph.GetVertex(key);
            //        Console.WriteLine("   " + vertex + " - " +
            //            node.GetEdge(graph.GetVertex(vertex)).Weight<double>()
            //            + " - " + key);
            //    }
            //}
            //Console.WriteLine($"Number of vertex in the graph: {graph.Count}");
            //-----------------
            //var graph = new DiGraph<char>(new char[] { 'A', 'B', 'C', 'D', 'E'});

            //graph.AddEdge('B', 'A');
            //graph.AddEdge('A', 'D');
            //graph.AddEdge('D', 'E');
            //graph.AddEdge('C', 'D');
            //graph.AddEdge('C', 'E');
            //graph.AddEdge('C', 'A');
            //graph.AddEdge('C', 'B');

            //Console.WriteLine("Edge between A and B ? " + graph.HasEdge('A', 'B'));

            //foreach (var key in graph)
            //{
            //    Console.WriteLine(key);
            //}

            //Console.WriteLine();

            //foreach (var key in graph)
            //{
            //    Console.WriteLine(key);
            //    foreach (var item in graph.GetVertex(key))
            //    {
            //        Console.WriteLine("   " + item);
            //    }
            //}
            //-----------------

            //var graph = new WeightedDiGraph<char, int>(new char[] { 'A', 'B', 'C', 'D', 'E'});

            //graph.AddEdge('A', 'C', 12);
            //graph.AddEdge('A', 'D', 60);
            //graph.AddEdge('B', 'A', 10);
            //graph.AddEdge('C', 'D', 32);
            //graph.AddEdge('C', 'B', 20);
            //graph.AddEdge('E', 'A', 7);

            //Console.WriteLine("Edge between A and B ? " + graph.HasEdge('A', 'B'));
            //Console.WriteLine("Edge between B and A ? " + graph.HasEdge('B', 'A'));

            //Console.WriteLine();

            //foreach (char vertexKey in graph)
            //{
            //    Console.WriteLine(vertexKey);
            //    foreach (char key in graph.GetVertex(vertexKey))
            //    {
            //        var nodeU = graph.GetVertex(vertexKey);
            //        var nodeV = graph.GetVertex(key);
            //        var w = nodeU.GetEdge(nodeV).Weight<int>();
            //        Console.WriteLine("   " + vertexKey + " - " +
            //            w + " - " + key);
            //    }
            //}
            //Console.WriteLine($"Number of vertex in the graph: {graph.Count}");
            #endregion

            #region DFS

            //var graph = new Graph<int>();

            //for (int i = 0; i <= 11; i++)
            //    graph.AddVertex(i);

            //graph.AddEdge(0, 1);
            //graph.AddEdge(1, 4);
            //graph.AddEdge(0, 4);
            //graph.AddEdge(0, 2);

            //graph.AddEdge(2, 5);
            //graph.AddEdge(2, 10);
            //graph.AddEdge(10, 11);
            //graph.AddEdge(11, 9);
            //graph.AddEdge(2, 9);

            //graph.AddEdge(5, 7);
            //graph.AddEdge(7, 8);
            //graph.AddEdge(5, 8);
            //graph.AddEdge(5, 6);

            //var algorithmDFS = new DepthFirst<int>();

            //Console.WriteLine(algorithmDFS.Find(graph, 100)); 
            //Console.WriteLine(algorithmDFS.Find(graph, 11));
            //Console.WriteLine();

            //var algorithmBFS = new BreadthFirst<int>();
            //Console.WriteLine(algorithmBFS.Find(graph, 100));
            //Console.WriteLine(algorithmBFS.Find(graph, 11));

            #endregion

            #region SortingAlgorithms

            //var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            
            //foreach (int i in arr) Console.Write(i + " ");
            //Console.WriteLine();

            ////SelectionSort.Sort(arr);
            ////SelectionSort.Sort(arr, SortDirection.Descending);
            ////BubbleSort.Sort(arr);
            ////InsertionSort.Sort(arr);
            ////InsertionSort.Sort(arr, SortDirection.Descending);
            ////QuickSort.Sort(arr);
            ////MergeSort.Sort(arr);


            //foreach (int i in arr) Console.Write(i + " ");
            #endregion
        }
    }
}
