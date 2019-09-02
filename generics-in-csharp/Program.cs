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
            var list = new LinkedListFloat();
            list.AddLast(1.5f);
            list.AddLast(2f);
            list.AddLast(2f);
            list.AddLast(3f);

            list.Remove(2f);

            var sum = 0f;
            while (list.Any())
            {
                var first = list.First;
                list.Remove(first);
                Console.WriteLine(first);

                try
                {
                    sum += first;
                }
                catch (Exception)
                {}
            }

            Console.WriteLine("Sum:"+ sum);

            Console.ReadLine();
        }
    }
}
