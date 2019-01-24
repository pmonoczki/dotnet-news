//-----------------------------------------------------------------------

// <copyright file="Program.cs" component="BCL">

//     Represents the new BCL functionalities.

// </copyright>

//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Collections.Concurrent;

namespace BCL
{
    /// <summary>
    /// This class support the demonstration of the parallel operations in DotNet 4.0
    /// </summary>
    class Program
    {
        // Task for testing paralleling.
        private static Action Task3;
        private static Action Task2;
        private static Action Task1;

        /// <summary>
        /// Entry point
        /// </summary>
        static void Main()
        {
            #region Parallel For
            
            //DoParallelForLoop();

            #endregion

            #region PLinq


           // DoPLINQ();

            #endregion


            #region Parallel Task

            //DoParallelTask();

            #endregion

            DoPipeLine();

            //DoSharedQueue();

           

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Introdices the concurrent collections.
        /// </summary>
        private static void DoSharedQueue()
        {
            var results =new ConcurrentQueue<long>();

            Parallel.For(0, 1000, (i) =>
            {
                long result =
                ComputeResult(i);
                results.Enqueue(result);
            });

            Console.WriteLine(results.Count);
        }

        /// <summary>
        /// Only for demo.
        /// </summary>
        /// <param name="i">do not care</param>
        /// <returns>int number</returns>
        private static long ComputeResult(long i)
        {
            return i * i;
        }

        /// <summary>
        /// Introduces the pipeline mechanism
        /// </summary>
        private static void DoPipeLine()
        {

            Console.WriteLine("{0} main Thread", Thread.CurrentThread.ManagedThreadId.ToString());
            string outFileName = Path.Combine(Environment.CurrentDirectory, "out.txt");
            var inp = new BlockingCollection<string>();
            var readLines = Task.Factory.StartNew(() =>
            {
                try
                {

                    foreach (var line in File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"input.txt")))
                    {
                        Console.WriteLine("{0} processed by {1} Thread", line, Thread.CurrentThread.ManagedThreadId.ToString());
                        inp.Add(line);
                    }
                }
                finally { inp.CompleteAdding(); }
            });
            var writeLines = Task.Factory.StartNew(() =>
            {
                File.WriteAllLines(Path.Combine(Environment.CurrentDirectory ,"out.txt"), inp.GetConsumingEnumerable());
            });

            Task.WaitAll(readLines, writeLines);

            Console.WriteLine("PIPELINE is ready.");
            Console.WriteLine(File.ReadAllText(outFileName));
        }

        /// <summary>
        /// Demonstrates the FOR and FOREACH parallel loops.
        /// </summary>
        private static void DoParallelForLoop()
        {

            // FOR

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
           
            // FOREACH

            string[] files = Directory.GetFiles(@"d:\jpegs", "*.jpg");
            string newDir = @"d:\Modified";
            if (!Directory.Exists(newDir))
                Directory.CreateDirectory(newDir);

            Parallel.ForEach(files, currentFile =>
            {

                string filename = Path.GetFileName(currentFile);
                Bitmap bitmap = new Bitmap(currentFile);

                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                bitmap.Save(Path.Combine(newDir, filename));

                Console.WriteLine("Processing {0} on thread {1}", filename,
                                    Thread.CurrentThread.ManagedThreadId);

            }
                 );

           
        }

        /// <summary>
        /// Introduces the parallel task concept
        /// </summary>
        private static void DoParallelTask()
        {

            // Parallel invoke

            Task1 = new Action(DoWork);
            Task2 = new Action(DoWork);
            Task3 = new Action(DoWork);

            System.Action[] actions =
       new System.Action[] { Task1, Task2, Task3 };
            Parallel.Invoke(actions);

            // TASK<>  
            // return value
            Task task = new Task(Task1);
            task.Start(TaskScheduler.Current);
           
        }

        /// <summary>
        /// Introduces the parallel Linq concept 
        /// </summary>
        private static void DoPLINQ()
        {
            var source = Enumerable.Range(1, 10);


            // Opt-in to PLINQ with AsParallel
            var evenNums = from num in source.AsParallel()
                           where Compute(num) > 0
                           select num;

            foreach (var item in evenNums)
            {
                Console.WriteLine(item.ToString());
            }
        }

        /// <summary>
        /// Only or demo
        /// </summary>
        private static void DoWork()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
        }

        /// <summary>
        /// Only or demo
        /// </summary>
        private static int Compute(int num)
        {
            Console.WriteLine("Processing on thread {0}",
                                    Thread.CurrentThread.ManagedThreadId);
            return 1;
        }
    }
}
