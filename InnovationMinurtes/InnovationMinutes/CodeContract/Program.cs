//-----------------------------------------------------------------------

// <copyright file="Program.cs" component="CodeContract">

//     Represents the new CodeContract functionalities.

// </copyright>

//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;
using System.IO;

namespace CodeContract
{
    /// <summary>
    /// CodeContract tester
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        static void Main()
        {

            // Assertion
            Contract.Assert(
                    NetworkInterface.GetIsNetworkAvailable(),
                "Network is not available.");

            // Assume
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            Contract.Assume(allDrives.Length != 0, "count of drive is 0");
            

            BC bc = new BC();
            string ret = bc.GetStringNumber(55);
            Console.WriteLine(ret);

            Console.ReadKey();
        }
    }
}
