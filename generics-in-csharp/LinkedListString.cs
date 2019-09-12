using System;

namespace generics_in_csharp
{
    public class LinkedListString
    {
        public class Node
        {
            // link to next Node in list
            public Node next = null;
            // value of this Node
            public string data;
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

        public void AddLast(string value)
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

        public void Remove(string data)
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
}
