using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BCL
{
    class Program
    {
        private static Action Task3;
        private static Action Task2;
        private static Action Task1;

        static void Main(string[] args)
        {
            #region Parallel For

            int[] nums = Enumerable.Range(0, 1000000).ToArray();
            long total = 0;

            // Use type parameter to make subtotal a long, not an int
            Parallel.For<long>(0, nums.Length, () => 0, (j, loop, subtotal) =>
            {
                subtotal += nums[j];
                return subtotal;
            },
                (x) => Interlocked.Add(ref total, x)
            );

            Console.WriteLine("The total is {0}", total);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            #endregion

            #region PLinq


            var source = Enumerable.Range(1, 10000);


            // Opt-in to PLINQ with AsParallel
            var evenNums = from num in source.AsParallel()
                           where Compute(num) > 0
                           select num;

            foreach (var item in evenNums)
            {
                Console.WriteLine(item.ToString());
            }

            #endregion


            #region Parallel Task


            Task1 = new Action(DoWork);
            Task2 = new Action(DoWork);
            Task3 = new Action(DoWork);

            System.Action[] actions =
       new System.Action[] { Task1, Task2, Task3 };
            Parallel.Invoke(actions);


            #endregion

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void DoWork()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
        }

        private static int Compute(int num)
        {
            return 1;
        }
    }
}
