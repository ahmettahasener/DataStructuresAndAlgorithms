using DataStructures.LinkedList.DoublyLinkedList;

namespace DataStructures.Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        public readonly DoublyLinkedList<T> list = new DoublyLinkedList<T>();
        public int Count { get; private set; }

        public T DeQueue()
        {
            if (Count == 0)
                throw new Exception("Queue is empty!");

            Count--;
            return list.RemoveFirst();
        }

        public void EnQueue(T value)
        {
            if(value == null)
                throw new ArgumentNullException();

            list.AddLast(value);
            Count++;
        }

        public T Peek() => Count == 0
            ? throw new Exception("Queue is empty!")
            : list.Head.Value;
    }
}