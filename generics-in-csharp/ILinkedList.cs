using System.Collections.Generic;

namespace generics_in_csharp
{
    public interface ILinkedList<T> : IEnumerable<T>
    {
        LinkedList<T>.Node<T> First { get; }

        void AddLast(T value);
        bool Any();
        void Remove(T data);
    }
}