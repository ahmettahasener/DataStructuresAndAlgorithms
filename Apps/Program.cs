using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.Stack;
using System;
using DataStructures.Tree.BinaryTree;

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

            #region BST

            var BST = new DataStructures.Tree.BST.BST<int>(new int[]
            {
                23,16,45,3,22,37,99
            });

            var listInOrder = new BinaryTree<int>().InOrder(BST.Root);

            foreach (var node in listInOrder)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();
            var listPreOrder = new BinaryTree<int>().PreOrder(BST.Root);

            foreach (var node in listPreOrder)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();

            var listPostOrder = new BinaryTree<int>().PostOrder(BST.Root);

            foreach (var node in listPostOrder)
            {
                Console.Write(node + " ");
            }
            #endregion

            #endregion
        }
    }
}
