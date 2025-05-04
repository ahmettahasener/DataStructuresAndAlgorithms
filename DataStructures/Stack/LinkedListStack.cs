using DataStructures.LinkedList.SinglyLinkedList;

namespace DataStructures.Stack
{
    internal class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>();
        public int Count { get; private set; }

        public void Clear()
        {
            list.Clear();
            Count = 0;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new Exception("Empty Stack!");

            return list.Head.Value;
        }

        public T Pop()
        {
            if(Count == 0)
                throw new Exception("Empty Stack!");

            var temp = list.RemoveFirst(); //This method returns T value.
            Count--;
            return temp;
        }

        public void Push(T value)
        {
            if(value == null) 
                throw new ArgumentNullException();

            list.AddFirst(value);
            Count++;
        }
    }
}