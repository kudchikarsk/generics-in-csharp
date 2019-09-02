using System;

namespace generics_in_csharp
{
    public class LinkedListFloat
    {
        public class Node
        {
            // link to next Node in list
            public Node next = null;
            // value of this Node
            public float data;
        }

        private Node root = null;

        public float First
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


        public void AddLast(float value)
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

        public void Remove(float n)
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
}
