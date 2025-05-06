
using DataStructures.Tree.BinaryTree;
using System.Collections;

namespace DataStructures.Tree.BST
{
    internal class BSTEnumerator<T> : IEnumerator<T> where T : IComparable
    {
        private List<Node<T>> list;
        private int index = -1;

        public BSTEnumerator(Node<T> root)
        {
            list = new BinaryTree<T>().LevelOrderNonRecursiveTraversal(root);
        }
        public T Current => list[index].Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            list = null;
            index = -1;
        }

        public bool MoveNext()
        {
            index++;
            return index < list.Count ? true : false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}