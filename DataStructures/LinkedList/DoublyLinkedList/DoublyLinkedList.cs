﻿using System.Collections;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable
    {
        public DoublyLinkedList()
        {
            
        }

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }
        private bool isHeadNull => Head == null;
        private bool isTailNull => Tail == null;
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (Head != null)
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;

            if (Tail == null)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            if(Tail == null)
            {
                AddFirst(value);
                return;
            }

            var newNode = new DoublyLinkedListNode<T>(value);

            Tail.Next = newNode;
            newNode.Next = null;
            newNode.Prev = Tail;
            Tail = newNode;
            return;
        }

        public void AddAfter(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException();
            }

            if (refNode == Head && refNode == Tail)
            {
                refNode.Next = newNode;
                refNode.Prev = null;

                newNode.Next = null;
                newNode.Prev = refNode;

                Head = refNode;
                Tail = newNode;
                return;
            }

            if (refNode != Tail)
            {
                newNode.Prev = refNode;
                newNode.Next = refNode.Next;

                refNode.Next.Prev = newNode;
                refNode.Next = newNode;
                return;
            }
            //ref node is Tail
            else
            {
                newNode.Prev = refNode;
                newNode.Next = null;

                refNode.Next = newNode;
                Tail = newNode;
            }
        }
        public void AddBefore(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException();
            }

            if (refNode == Head && refNode == Tail) {
                refNode.Next = null;
                refNode.Prev = newNode;

                newNode.Next = refNode;
                newNode.Prev = null;

                Tail = refNode;
                Head = newNode;
            }

            if (refNode != Head)
            {
                newNode.Next = refNode;
                newNode.Prev = refNode.Prev;

                refNode.Prev.Next = newNode;
                refNode.Prev = newNode;
                return;
            }
            //ref node is Head
            else
            {
                refNode.Prev = newNode;

                newNode.Next = refNode;
                newNode.Prev = null;

                Head = newNode;
            }
        }
        public T RemoveFirst()
        {
            if (isHeadNull)
            {
                throw new ArgumentNullException();
            }
            var temp = Head.Value;

            if (Head==Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            return temp;
        }

        public T RemoveLast()
        {
            if (isTailNull)
                throw new ArgumentNullException();

            var temp = Tail.Value;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }
            return temp;
        }
        public void Remove(T value)
        {
            if (isHeadNull)
                throw new ArgumentNullException();

            if (Head == Tail)
            {
                if (Head.Value.Equals(value))
                {
                    RemoveFirst();
                }
                return;
            }

            var current = Head;
            while (current != null)
            {
                if(current.Value.Equals(value))
                {
                    //current = Head
                    if (current.Prev == null)
                    {
                        current.Next.Prev = null;
                        Head = current.Next;
                    }
                    //current = Tail
                    else if (current.Next == null)
                    {
                        current.Prev.Next = null;
                        Tail = current.Prev;
                    }
                    //mid position
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                    }
                    break;
                }
                current = current.Next;
            }

        }
        private List<DoublyLinkedListNode<T>> GetAllNodes()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;

            while (current != null)
            {
                list.Add(current);
                current = current.Next;
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator();
        }


    }
}