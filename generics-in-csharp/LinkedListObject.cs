using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_in_csharp
{
    public class LinkedListObject
    {
        public class Node
        {
            // link to next Node in list
            public Node next = null;
            // value of this Node
            public object data;
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

        public void Remove(object data)
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
