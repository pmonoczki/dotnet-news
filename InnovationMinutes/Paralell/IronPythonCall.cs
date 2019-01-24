using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPython.Hosting;

namespace Paralell
{
    class IronPythonCall
    {
        public static void CallScript()
        {
            var ipy = Python.CreateRuntime();
            dynamic test = ipy.UseFile("Test.py");
            test.Simple();
            // test.NonexistentMethod();
            Console.ReadLine();
        }

    }
}
