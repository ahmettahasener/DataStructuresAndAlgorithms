using System.Collections;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedList()
        {
            
        }

        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }

        public SinglyLinkedListNode<T> Head { get; set; }
        private bool isHeadNull => Head == null;

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if(isHeadNull)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddAfter(SinglyLinkedListNode<T> node,T value)
        {
            if(node == null)
            {
                throw new ArgumentNullException();
            }

            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while(current.Next != null)
            {
                if(current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }
        
        public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if(refNode == null || newNode == null) { throw new ArgumentNullException(); }


            if (isHeadNull)
            {
                Head = newNode;
                return;
            }

            newNode.Next = refNode.Next;
            refNode.Next = newNode;
        }

        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);

            var current = Head;
            while (current.Next != null)
            {
                if (current.Next.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");

        }

        public void AddBefore(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (refNode == null || newNode == null) { throw new ArgumentNullException(); }


            if (isHeadNull)
            {
                Head = newNode;
                return;
            }

            var current = Head;

            while (current.Next != null)
            {
                if (current.Next.Equals(refNode)){
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception("Nothing to remove.");

            var firstValue = Head.Value;
            Head = Head.Next;
            return firstValue;
        }

        public T RemoveLast()
        {
            if (isHeadNull)
                throw new Exception("Nothing to remove.");

            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
            }

            var lastValue = prev.Next.Value;
            prev.Next = null;
            return lastValue;
        }

        public void Remove(T value)
        {
            if (isHeadNull)
                throw new Exception("Nothing to remove.");

            if(value == null)
                throw new ArgumentNullException("Value is null.");

            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            do
            {
                if(current.Value.Equals(value))
                {
                    //last item
                    if(current.Next == null)
                    {
                        //head
                        if(prev == null)
                        {
                            Head = null;
                            return;
                        }
                        //normal last element
                        else
                        {
                            prev.Next = null;
                            return;
                        }
                    }
                    else
                    {
                        //head
                        if(prev == null)
                        {
                            Head = Head.Next;
                            return;
                        }
                        else
                        {
                            prev.Next = current.Next;
                            return;
                        }
                    }
                }
                prev = current;
                current = current.Next;
            } while (current != null);

            throw new Exception("The value could not be found.");
        }

        public void Clear()
        {
            if (isHeadNull)
                return;
            var current = Head;
            while (current != null)
            {
                RemoveFirst();
                current = current.Next;
            }
        }
    }
}
