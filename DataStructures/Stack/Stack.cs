﻿namespace DataStructures.Stack
{
    public class Stack<T>
    {
        private readonly IStack<T> stack;
        public int Count => stack.Count;
        public Stack(StackType type = StackType.Array)
        {
            if(type == StackType.Array)
            {
                stack = new ArrayStack<T>();
            }
            else
            {
                stack = new LinkedListStack<T>();
            }
        }
        public T Pop()
        {
            return stack.Pop();
        }
        public T Peek()
        {
            return stack.Peek();
        }
        public void Push(T value)
        {
            stack.Push(value);
        }

        public void Clear()
        {
            stack.Clear();
        }
    }

    public interface IStack<T>
    {
        int Count { get; }
        void Push(T item);
        T Pop();
        T Peek();
        void Clear();
    }

    public enum StackType
    {
        Array = 0, //List<T>
        LinkedList = 1 //SinglyLinkedList<T>
    }
}
