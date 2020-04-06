using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._2._2
{
    class BinaryTreeNode<T> : IEnumerable
    {
        public T data;
        public BinaryTreeNode<T> Rson;
        public BinaryTreeNode<T> Lson;
        //przechodzenie w głąb, bez yield
        /*
        public class TreeEnumerator : IEnumerator
        {
            private Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            private BinaryTreeNode<T> root, curr; 
            public TreeEnumerator(BinaryTreeNode<T> tree)
            {
                this.root = tree;
                this.Reset();
            }
            public object Current
            {
                get
                {
                    if (curr != null)
                    {
                        return curr.data;
                    }
                    else
                    {
                        throw new ArgumentException("Brak elementu do zwrócenia wartości");
                    }
                }
            }
            public bool MoveNext()
            {
                if (stack.Count > 0)
                {
                    curr = stack.Pop();
                    if (curr.Rson != null) stack.Push(curr.Rson);
                    if (curr.Lson != null) stack.Push(curr.Lson);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Reset()
            {
                stack.Clear();
                stack.Push(this.root);
                this.curr = this.root;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new TreeEnumerator(this);
        }
        */
        //przechodzenie w szerz, bez yield
        /*
        public class TreeEnumerator : IEnumerator
        {
            private Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            private BinaryTreeNode<T> root, curr;
            public TreeEnumerator(BinaryTreeNode<T> tree)
            {
                this.root = tree;
                this.Reset();
            }
            public object Current
            {
                get
                {
                    if (curr != null)
                    {
                        return curr.data;
                    }
                    else
                    {
                        throw new ArgumentException("Brak elementu do zwrócenia wartości");
                    }
                }
            }
            public bool MoveNext()
            {
                if (queue.Count > 0)
                {
                    curr = queue.Dequeue();
                    if (curr.Lson != null) queue.Enqueue(curr.Lson);
                    if (curr.Rson != null) queue.Enqueue(curr.Rson);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Reset()
            {
                queue.Clear();
                queue.Enqueue(this.root);
                this.curr = this.root;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new TreeEnumerator(this);
        }
        */
        //przechodzenie w głąd, z yield
        /*
        public IEnumerator GetEnumerator()
        {
            yield return this.data;
            if (this.Lson != null)
                foreach (var elem in this.Lson)
                    yield return elem;
            if (this.Rson != null)
                foreach (var elem in this.Rson)
                    yield return elem;
        }
        */
        //przechodzenie w szerz, z yeld
        public IEnumerator GetEnumerator()
        {
            Queue<BinaryTreeNode<T>> Q = new Queue<BinaryTreeNode<T>>();
            BinaryTreeNode<T> node;
            Q.Enqueue(this);
            while (Q.Count > 0)
            {
                node = Q.Dequeue();
                yield return node.data;
                if (node.Lson != null) Q.Enqueue(node.Lson);
                if (node.Rson != null) Q.Enqueue(node.Rson);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BinaryTreeNode<int> root = new BinaryTreeNode<int>();
            root.data = 1;
            BinaryTreeNode<int> left = new BinaryTreeNode<int>();
            left.data = 2;
            BinaryTreeNode<int> subleft = new BinaryTreeNode<int>();
            subleft.data = 3;
            left.Rson = subleft;
            BinaryTreeNode<int> right = new BinaryTreeNode<int>();
            right.data = 4;
            BinaryTreeNode<int> subright1 = new BinaryTreeNode<int>();
            subright1.data = 5;
            right.Lson = subright1;
            BinaryTreeNode<int> subright2 = new BinaryTreeNode<int>();
            subright2.data = 6;
            right.Rson = subright2;
            root.Lson = left;
            root.Rson = right;
            foreach (int elem in root)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
