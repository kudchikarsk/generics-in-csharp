using System;

namespace generics_in_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(2);
            list.AddLast(3);
            list.Remove(2);
            var sum = 0;
            foreach (var item in list)
            {
                sum += item;
                Console.WriteLine(item);
            }
            Console.WriteLine("Sum:"+ sum);
            Console.ReadLine();
        }
    }
}
