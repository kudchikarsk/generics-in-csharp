using System;
using System.Collections;
using System.Collections.Generic;

namespace generics_in_csharp
{
    public class LinkedList
    {
        public class Node
        {
            // link to next Node in list
            public Node next = null;
            // value of this Node
            public int data;
        }

        private Node root = null;

        public Node First
        {
            get
            {
                return root;
            }
        }

        public bool Any()
        {
            return root != null;
        }

        public void AddLast(int value)
        {
            Node n = new Node { data = value };
            if (root == null)
            {
                root = n;
            }   
            else
            {
                Node curr = root;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = n;
            }                
        }

        public void Remove(int data)
        {
            if (root != null && Object.Equals(root.data, data))
            {
                var node = root;
                root = node.next;
                node.next = null;
            }
            else
            {
                Node curr = root;
                while (curr.next != null)
                {
                    if (curr.next != null && Object.Equals(curr.next.data, data))
                    {
                        var node = curr.next;
                        curr.next = node.next;
                        node.next = null;
                        break;
                    }
                    curr = curr.next;
                }
            }
        }
    }

    public class LinkedList<T> : IEnumerable<T>
    {
        public class Node<T>
        {
            // link to next Node in list
            public Node<T> next = null;
            // value of this Node
            public T data;
        }

        private Node<T> root = null;

        public Node<T> First
        {
            get
            {
                return root;
            }
        }

        public bool Any()
        {
            return root != null;
        }

        public void AddLast(T value)
        {
            Node<T> n = new Node<T> { data = value };
            if (root == null)
            {
                root = n;
            }
            else
            {
                Node<T> curr = root;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = n;
            }
        }

        public void Remove(T data)
        {
            if (root != null && Object.Equals(root.data, data))
            {
                var node = root;
                root = node.next;
                node.next = null;
            }
            else
            {
                Node<T> curr = root;
                while (curr.next != null)
                {
                    if (curr.next != null && Object.Equals(curr.next.data, data))
                    {
                        var node = curr.next;
                        curr.next = node.next;
                        node.next = null;
                        break;
                    }
                    curr = curr.next;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> curr = root;
            while (curr != null)
            {
                yield return curr.data;
                curr = curr.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
