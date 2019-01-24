using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace MemoryMappedFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(
    Path.Combine(Environment.CurrentDirectory, "readme.txt"), FileMode.Open);
            MemoryMappedFile mmf =
              MemoryMappedFile.CreateFromFile(Path.Combine(Environment.CurrentDirectory, "readme.txt"));
            MemoryMappedViewAccessor accessor =
              mmf.CreateViewAccessor();


            
        }
    }
}
