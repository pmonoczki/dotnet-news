//-----------------------------------------------------------------------

// <copyright file="BC.cs" component="CodeContract">

//     Represents the new CodeContract functionalities.

// </copyright>

//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;
using System.IO;

namespace CodeContract
{
    /// <summary>
    /// CodeContract demonstration
    /// </summary>
    public class BC 
    {
        /// <summary>
        /// Gets a string that is a conversation of int
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string GetStringNumber(int num)
        {
           

            // Requires
            Contract.Requires(num > 5, "not greather than 5");

            // Ensures
            Contract.Ensures(Contract.Result<string>() != null, "The incoming num should not be null as return! Avoid the use of num 9!");

            string retVal = null;




            if (num != 9)
            {
                retVal = num.ToString();
            }

            

            return retVal;

        }
    }
}
