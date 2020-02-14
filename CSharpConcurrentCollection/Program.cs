using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpConcurrentCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var t1 = Task.Run(() => list.RemoveAt(0));
            var t2 = Task.Run(() => list.RemoveAt(0));
            var t3 = Task.Run(() => list.RemoveAt(0));

            Task.WaitAll(t1, t2, t3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("done...");
        }
    }
}
