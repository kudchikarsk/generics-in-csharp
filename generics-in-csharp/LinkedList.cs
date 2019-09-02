using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_in_csharp
{
    public class LinkedList
    {
        public class Node
        {
            // link to next Node in list
            public Node next = null;
            // value of this Node
            public object data;
        }

        private Node root = null;

        public object First
        {
            get
            {
                if (root == null)
                {
                    throw new IndexOutOfRangeException();
                }

                return root.data;
            }
        }

        public bool Any()
        {
            return root != null;
        }

        public object Last
        {
            get
            {
                Node curr = root;
                if (curr == null)
                {
                    throw new IndexOutOfRangeException();
                }

                while (curr.next != null)
                {
                    curr = curr.next;
                }                    
                return curr.data;
            }
        }
       

        public void AddLast(object value)
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

        public void Remove(object n)
        {
            if (object.Equals(root.data, n))
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
                    if (object.Equals(curr.next.data, n))
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

    public class LinkedList<T>
    {
        public class Node<T>
        {
            // link to next Node in list
            public Node<T> next = null;
            // value of this Node
            public T data;
        }

        private Node<T> root = null;

        public T First
        {
            get
            {
                if (root == null)
                {
                    throw new IndexOutOfRangeException();
                }

                return root.data;
            }
        }

        public bool Any()
        {
            return root != null;
        }

        public T Last
        {
            get
            {
                Node<T> curr = root;
                if (curr == null)
                {
                    throw new IndexOutOfRangeException();
                }

                while (curr.next != null)
                {
                    curr = curr.next;
                }
                return curr.data;
            }
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

        public void Remove(T n)
        {
            if (object.Equals(root.data, n))
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
                    if (object.Equals(curr.next.data, n))
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
}
