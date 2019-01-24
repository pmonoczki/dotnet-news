using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleOutputter
{
  class Program
  {
    static void Main(string[] args)
    {
      foreach (var i in Enumerable.Range(1, 100))
      {
        if ((i % 2) == 0)
        {
          Console.Out.WriteLine("{0}", i);
        }
        else
        {
          Console.Error.WriteLine("{0}", i);
        }

        // Just put in a little delay to simulate some processing
        Thread.Sleep(1);
      }

    }
  }
}
