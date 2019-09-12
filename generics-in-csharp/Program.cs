using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_in_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new LinkedListObject();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast("John Doe");
            list.Remove(2);
            var sum = 0;
            while (list.Any())
            {
                var first = list.First;
                list.Remove(first.data);
                Console.WriteLine(first.data);
                try
                {
                    sum += (int)first.data;
                }
                catch (Exception)
                {}
            }
            Console.WriteLine("Sum:"+ sum);
            Console.ReadLine();
        }
    }
}
