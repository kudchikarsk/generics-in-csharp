using System;

namespace generics_in_csharp
{
    public delegate void Printer<T>(T data);

    public class Program
    {
        

        public static void Main(string[] args)
        {
            LinkedList<int> list = GenerateData();
            list.Display(Console.WriteLine);
            Console.ReadLine();
        }

        private static LinkedList<int> GenerateData()
        {
            var list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(2);
            list.AddLast(3);
            list.Remove(2);
            return list;
        }
    }

    public static class Extension
    {
        public static void Display<T>(this LinkedList<T> list, Printer<T> printer)
        {
            foreach (var item in list)
            {
                printer(item);
            }
        }
    }
}
