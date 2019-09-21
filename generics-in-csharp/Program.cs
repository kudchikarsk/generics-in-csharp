using System;

namespace generics_in_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new LinkedList<double>();
            list.AddLast(1.5);
            list.AddLast(2.2);
            list.AddLast(2.6);
            list.AddLast(3.3);
            list.Remove(2.2);
            var sum = 0D;
            foreach (var item in list.AsEnumerableOf<int>())
            {
                sum += item;
                Console.WriteLine(item);
            }
            Console.WriteLine("Sum:" + sum);
            Console.ReadLine();
        }
    }
}
